using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Info
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("exportedAt")]
        public string ExportedAt { get; set; }

        [JsonProperty("mapName")]
        public string MapName { get; set; }

        [JsonProperty("seed")]
        public string Seed { get; set; }

        [JsonProperty("mapId")]
        public long MapId { get; set; }
    }
}
