using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Cell
    {
        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("v")]
        public List<int> V { get; set; }

        [JsonPropertyName("c")]
        public List<int> C { get; set; }

        [JsonPropertyName("p")]
        public List<float> P { get; set; }

        [JsonPropertyName("g")]
        public int G { get; set; }

        [JsonPropertyName("h")]
        public int H { get; set; }

        [JsonPropertyName("area")]
        public int Area { get; set; }

        [JsonPropertyName("f")]
        public int F { get; set; }

        [JsonPropertyName("t")]
        public int T { get; set; }

        [JsonPropertyName("haven")]
        public int Haven { get; set; }

        [JsonPropertyName("harbor")]
        public int Harbor { get; set; }

        [JsonPropertyName("fl")]
        public int Fl { get; set; }

        [JsonPropertyName("r")]
        public int R { get; set; }

        [JsonPropertyName("conf")]
        public int Conf { get; set; }

        [JsonPropertyName("biome")]
        public int Biome { get; set; }

        [JsonPropertyName("s")]
        public int S { get; set; }

        [JsonPropertyName("pop")]
        public float Pop { get; set; }

        [JsonPropertyName("culture")]
        public int Culture { get; set; }

        [JsonPropertyName("burg")]
        public int Burg { get; set; }

        [JsonPropertyName("road")]
        public int Road { get; set; }

        [JsonPropertyName("crossroad")]
        public int Crossroad { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("religion")]
        public int Religion { get; set; }

        [JsonPropertyName("province")]
        public int Province { get; set; }
    }
}
