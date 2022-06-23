using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Biomes
    {

        [JsonPropertyName("i")]
        public List<int> I { get; set; }

        [JsonPropertyName("name")]
        public List<string> Name { get; set; }

        [JsonPropertyName("color")]
        public List<string> Color { get; set; }

        [JsonPropertyName("biomesMartix")]
        public List<Dictionary<int, int>> BiomesMartix { get; set; }

        [JsonPropertyName("habitability")]
        public List<int> Habitability { get; set; }

        [JsonPropertyName("iconsDensity")]
        public List<int> IconsDensity { get; set; }

        [JsonPropertyName("icons")]
        public List<List<string>> Icons { get; set; }

        [JsonPropertyName("cost")]
        public List<int> Cost { get; set; }
    }
}
