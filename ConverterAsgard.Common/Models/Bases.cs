using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Bases
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("i")]
        public int I { get; set; }

        [JsonProperty("min")]
        public int min { get; set; }

        [JsonProperty("max")]
        public int max { get; set; }

        [JsonProperty("d")]
        public string D { get; set; }

        [JsonProperty("m")]
        public float M { get; set; }

        [JsonProperty("b")]
        public string B { get; set; }
    }
}
