using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Marker
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("dx")]
        public int Dx { get; set; }

        [JsonProperty("px")]
        public int Px { get; set; }

        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }

        [JsonProperty("cell")]
        public int Cell { get; set; }

        [JsonProperty("i")]
        public int I { get; set; }
    }
}
