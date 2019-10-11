using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alien_Isolation_Mod_Manager.Classes;

namespace Alien_Isolation_Mod_Manager
{
    public partial class Main : Form
    {
        private static readonly string[] modDirectories = { "Mods" };
        public List<Mod> Mods;
        public BindingSource Source = new BindingSource();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txt_description.Clear();
            Mods = LoadMods();
            Source.DataSource = Mods;
            lst_mods.DataSource = Mods;
        }

        private List<Mod> LoadMods()
        {
            var ret = new List<Mod>();
            foreach (var modDir in modDirectories)
            {
                foreach (var modFolder in Directory.GetDirectories(modDir))
                {
                    var mod = new Mod(modFolder);
                    txt_description.AppendLine(mod.ToJson());
                    ret.Add(mod);
                }
            }
            return ret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private async void createMD5TreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var progress = new Progress<ProgressReport>(report =>
            {
                bar_progress.Maximum = report.TotalFilesFound;
                bar_progress.Value = report.TotalFilesHashed;
                txt_status.Text = $@"Found: {report.TotalFilesFound} Read: {report.TotalFilesRead} Hashed: {report.TotalFilesHashed} Uploaded: {report.TotalFilesUploaded}";
            });
            await new Example().ProcessFiles(Environment.CurrentDirectory, progress, txt_description);
            /*foreach (var file in Directory.GetFileSystemEntries(Environment.CurrentDirectory, "*", SearchOption.AllDirectories))
            {
                txt_description.AppendText(file);
            }*/
        }

        private static void CalculateMD5(string filename)
        {
            /*using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true)) // true means use IO async operations
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = await stream.ReadAsync(buffer, 0, 4096);
                        if (bytesRead > 0)
                        {
                            md5.TransformBlock(buffer, 0, bytesRead, null, 0);
                        }
                    } while (bytesRead > 0);

                    md5.TransformFinalBlock(buffer, 0, 0);
                    return BitConverter.ToString(md5.Hash).Replace("-", "").ToUpperInvariant();
                }*/
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e) => Main_Load(null, null);

        private void FillMod(Mod mod)
        {
            txt_description.Clear();
            txt_description.Text = mod.ToJson();
            tabs_configs.TabPages.Clear();
            tabs_configs.TabPages.Add("Info");
            foreach (var cfgFile in mod.ConfigFiles)
            {
                var tab = new TabPage(cfgFile.Name) { Tag = cfgFile };
                tabs_configs.TabPages.Add(tab);
            }
            foreach (var cfgFile in mod.ReadmeFiles)
            {
                var tab = new TabPage(cfgFile.Name) { Tag = cfgFile };
                tabs_configs.TabPages.Add(tab);
            }
        }

        private void lst_mods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = lst_mods.Rows[e.RowIndex];
            var mod = (Mod)row.DataBoundItem;
            FillMod(mod);
        }

        private void tabs_configs_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage is null) return;
            if (e.TabPage.Tag is null)
            {
                var mod = (Mod)lst_mods.SelectedRows[0].DataBoundItem;
                txt_description.Text = mod.ToJson();
                return;
            }
            var file = (FileInfo)e.TabPage.Tag;
            var txt = file.ReadAllText();
            txt_description.Clear();
            if (file.Extension.ToLower() == ".rtf") txt_description.Rtf = txt;
            else txt_description.Text = txt;
        }
    }
}