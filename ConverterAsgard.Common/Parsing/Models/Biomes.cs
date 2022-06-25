using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class Biomes
    {

        [JsonProperty("i")]
        public List<int> I { get; set; }

        [JsonProperty("name")]
        public List<string> Name { get; set; }

        [JsonProperty("color")]
        public List<string> Color { get; set; }

        [JsonProperty("biomesMartix")]
        public List<Dictionary<int, int>> BiomesMartix { get; set; }

        [JsonProperty("habitability")]
        public List<int> Habitability { get; set; }

        [JsonProperty("iconsDensity")]
        public List<int> IconsDensity { get; set; }

        [JsonProperty("icons")]
        public List<List<string>> Icons { get; set; }

        [JsonProperty("cost")]
        public List<int> Cost { get; set; }
    }
}
