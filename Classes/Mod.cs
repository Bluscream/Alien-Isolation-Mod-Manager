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
                var _rel = file.GetRelativePathFrom(Path);
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
                if (Stuff.ReadmeExtensions.Any(x => file.Extension.ToLower() == x))
                {
                    ReadmeFiles.Add(file);
                }
            }
            // ConfigFiles = Files.Where(t => Stuff.ConfigExtensions.Any(t => t.ToLower().EndsWith(".cfg"));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}