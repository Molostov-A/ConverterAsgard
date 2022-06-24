using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Cell
    {
        [JsonProperty("i")]
        public int I { get; set; }

        [JsonProperty("v")]
        public List<int> V { get; set; }

        [JsonProperty("c")]
        public List<int> C { get; set; }

        [JsonProperty("p")]
        public List<float> P { get; set; }

        [JsonProperty("g")]
        public int G { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }

        [JsonProperty("area")]
        public int Area { get; set; }

        [JsonProperty("f")]
        public int F { get; set; }

        [JsonProperty("t")]
        public int T { get; set; }

        [JsonProperty("haven")]
        public int Haven { get; set; }

        [JsonProperty("harbor")]
        public int Harbor { get; set; }

        [JsonProperty("fl")]
        public int Fl { get; set; }

        [JsonProperty("r")]
        public int R { get; set; }

        [JsonProperty("conf")]
        public int Conf { get; set; }

        [JsonProperty("biome")]
        public int Biome { get; set; }

        [JsonProperty("s")]
        public int S { get; set; }

        [JsonProperty("pop")]
        public float Pop { get; set; }

        [JsonProperty("culture")]
        public int Culture { get; set; }

        [JsonProperty("burg")]
        public int Burg { get; set; }

        [JsonProperty("road")]
        public int Road { get; set; }

        [JsonProperty("crossroad")]
        public int Crossroad { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("religion")]
        public int Religion { get; set; }

        [JsonProperty("province")]
        public int Province { get; set; }
    }
}
