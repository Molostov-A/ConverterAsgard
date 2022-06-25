using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class Burg
    {
        [JsonProperty("cell")]
        public int cell { get; set; }

        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("i")]
        public int I { get; set; }

        [JsonProperty("culture")]
        public int Culture { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("feature")]
        public int Feature { get; set; }

        [JsonProperty("capital")]
        public int Capital { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("population")]
        public float Population { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coa")]
        public Coa Coa { get; set; }

        [JsonProperty("citadel")]
        public int Citadel { get; set; }

        [JsonProperty("plaza")]
        public int Plaza { get; set; }

        [JsonProperty("walls")]
        public int Walls { get; set; }

        [JsonProperty("shanty")]
        public int Shanty { get; set; }

        [JsonProperty("temple")]
        public int Temple { get; set; }
    }

}
