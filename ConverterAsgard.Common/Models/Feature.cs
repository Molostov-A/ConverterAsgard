using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Feature
    {
        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("land")]
        public bool Land { get; set; }

        [JsonPropertyName("border")]
        public bool Border { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("cells")]
        public int Cells { get; set; }

        [JsonPropertyName("firstCell")]
        public int FirstCell { get; set; }

        [JsonPropertyName("group")]
        public string Group { get; set; }
    }
}
