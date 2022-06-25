using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class Religion
    {
        [JsonProperty("i")]
        public int I { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("culture")]
        public int Culture { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("deity")]
        public string Deity { get; set; }

        [JsonProperty("center")]
        public int Center { get; set; }

        [JsonProperty("origins")]
        public int[] Origins { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
