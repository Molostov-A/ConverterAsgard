using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Marker
    {
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("dx")]
        public int Dx { get; set; }

        [JsonPropertyName("px")]
        public int Px { get; set; }

        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }

        [JsonPropertyName("cell")]
        public int Cell { get; set; }

        [JsonPropertyName("i")]
        public int I { get; set; }
    }
}
