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
        public int[] Id { get; set; }

        [JsonPropertyName("name")]
        public string[] Name { get; set; }

        [JsonPropertyName("color")]
        public string[] Color { get; set; }

        [JsonPropertyName("biomesMartix")]
        public BiomeMatrix[] BiomesMartix { get; set; }

        [JsonPropertyName("habitability")]
        public int[] Habitability { get; set; }

        [JsonPropertyName("iconsDensity")]
        public int[] IconsDensity { get; set; }

        [JsonPropertyName("icons")]
        public string[][] Icons { get; set; }
    }

    public enum BiomeMatrix
    {
    }
}
