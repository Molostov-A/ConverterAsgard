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
        public int Cell { get; set; }

        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }

        [JsonProperty("bx")]
        public float Bx { get; set; }

        [JsonProperty("by")]
        public float By { get; set; }

        [JsonProperty("u")]
        public GroupArmy U { get; set; }

        [JsonProperty("n")]
        public int N { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}
