using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_Isolation_Mod_Manager.Classes
{
    internal class Stuff
    {
        internal static readonly string[] ConfigExtensions = { ".cfg", ".ini", ".json", ".yaml", ".yml" };
        internal static readonly string[] ReadmeExtensions = { ".md", ".rtf", ".nfo", ".txt" };
    }

    public class Mod
    {
        public string Name => Path.Name;

        [System.ComponentModel.Browsable(false)]
        public DirectoryInfo Path { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string[] Dependencies { get; set; }

        [System.ComponentModel.Browsable(false)]
        public List<string> Files { get; set; }

        [System.ComponentModel.Browsable(false)]
        public Version MinGameVersion { get; set; }

        [System.ComponentModel.Browsable(false)]
        public Version MaxGameVersion { get; set; }

        [System.ComponentModel.Browsable(false)]
        public List<FileInfo> ConfigFiles { get; set; } = new List<FileInfo>();

        [System.ComponentModel.Browsable(false)]
        public List<FileInfo> ReadmeFiles { get; set; } = new List<FileInfo>();

        public Mod(string path)
        {
            Path = new DirectoryInfo(path);
            Files = Path.GetFiles("*", SearchOption.AllDirectories).Select(t => t.GetRelativePathFrom(Path)).ToList();
            foreach (var file in Files)
            {
                var _file = file.ToLower();
                if (Stuff.ConfigExtensions.Any(x => _file.EndsWith(x)))
                {
                    ConfigFiles.Add(Path.CombineFile(file));
                }
                if (Stuff.ReadmeExtensions.Any(x => _file.EndsWith(x)))
                {
                    ReadmeFiles.Add(Path.CombineFile(file));
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