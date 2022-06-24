using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Military
    {
        [JsonProperty("i")]
        public int I { get; set; }

        [JsonProperty("a")]
        public int A { get; set; }

        [JsonProperty("cell")]
        public int cell { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("bx")]
        public int bx { get; set; }

        [JsonProperty("by")]
        public int by { get; set; }

        [JsonProperty("u")]
        public GroupArmy U { get; set; }

        [JsonProperty("n")]
        public int N { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("icon")]
        public string icon { get; set; }
    }
}
