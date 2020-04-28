using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_Isolation_Mod_Manager.Classes
{
    public partial class ModManifest
    {
        [JsonIgnore]
        public FileInfo File { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public Version Version { get; set; }

        [JsonProperty("release", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Release { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Thumbnail { get; set; }

        [JsonProperty("download-url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri DownloadUrl { get; set; }

        [JsonProperty("manifest-url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ManifestUrl { get; set; }

        [JsonProperty("authors", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Dictionary<string, string>> Authors { get; set; }

        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Urls { get; set; }

        [JsonProperty("dependencies", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Dependencies { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("game", NullValueHandling = NullValueHandling.Ignore)]
        public ModManifestGame Game { get; set; }
    }

    public partial class ModManifestGame
    {
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public ModManifestGameVersion Version { get; set; }
    }

    public partial class ModManifestGameVersion
    {
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public Version Min { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public Version Max { get; set; }
    }
}