using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Army
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rural")]
        public float Rural { get; set; }

        [JsonProperty("urban")]
        public float Urban { get; set; }

        [JsonProperty("crew")]
        public int Crew { get; set; }

        [JsonProperty("power")]
        public int Power { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("separate")]
        public int Separate { get; set; }
    }
}
