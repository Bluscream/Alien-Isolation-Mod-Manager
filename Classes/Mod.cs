using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Alien_Isolation_Mod_Manager.Classes
{
    internal class Stuff
    {
        internal static readonly string[] ConfigExtensions = { ".cfg", ".ini", ".json", ".yaml", ".yml", ".html" };
        internal static readonly string[] ReadmeExtensions = { ".md", ".rtf", ".nfo", ".txt" };
    }

    public class Mod
    {
        // [System.ComponentModel.Browsable(false)]
        public bool Enabled
        {
            get; set;
        } = false;

        // [System.ComponentModel.Browsable(false)]
        public bool Installed { get { return Enabled; } set { Install(); } }

        public string Name => Path.Name;

        [System.ComponentModel.Browsable(false)]
        public DirectoryInfo Path { get; set; }

        [System.ComponentModel.Browsable(false)]
        public List<FileInfo> Files { get; set; }

        [System.ComponentModel.Browsable(false)]
        public List<FileInfo> ConfigFiles { get; set; } = new List<FileInfo>();

        [System.ComponentModel.Browsable(false)]
        public List<FileInfo> ReadmeFiles { get; set; } = new List<FileInfo>();

        [System.ComponentModel.Browsable(false)]
        public ModManifest Manifest { get; set; }

        public Mod(string path)
        {
            Path = new DirectoryInfo(path);
            // Files = Path.GetFiles("*", SearchOption.AllDirectories).Select(t => t.GetRelativePathFrom(Path)).ToList();
            Files = Path.GetFiles("*", SearchOption.AllDirectories).ToList();
            foreach (var file in Files)
            {
                // System.Windows.Forms.MessageBox.Show(_file);
                if (file.Name.ToLower() == "mod.json")
                {
                    if (file.Exists)
                    {
                        Manifest = JsonConvert.DeserializeObject<ModManifest>(file.ReadAllText());
                        Manifest.File = file;
                        /*foreach (var property in GetType().GetProperties())
                        if (property.GetCustomAttributes(typeof (XmlIgnoreAttribute), false).GetLength(0) == 0)
                            property.SetValue(this, property.GetValue(tmp, null), null);*/
                    }
                }
                else if (Stuff.ConfigExtensions.Any(x => file.Extension.ToLower() == x))
                {
                    ConfigFiles.Add(file);
                }
                else if (Stuff.ReadmeExtensions.Any(x => file.Extension.ToLower() == x))
                {
                    ReadmeFiles.Add(file);
                }
                else
                {
                    var _rel = new FileInfo(file.GetRelativePathFrom(Path));
                    if (!Enabled && _rel.Exists && _rel.Length == file.Length) Enabled = true; // Todo: Improve detection (maybe check all files and use real checksum?)
                }
            }
            // ConfigFiles = Files.Where(t => Stuff.ConfigExtensions.Any(t => t.ToLower().EndsWith(".cfg"));
        }

        public bool Install()
        {
            foreach (var file in Files.Except(ConfigFiles).Except(ReadmeFiles))
            {
                var _rel = file.GetRelativePathFrom(Path);
                var _path = Path.Parent.Parent.CombineFile(_rel);
                var _bak = Path.CombineFile("Backup", _rel);
                if (!_bak.Exists)
                {
                    // Todo: add logging
                    file.CopyTo(_bak.FullName);
                }
            }
            return true;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}