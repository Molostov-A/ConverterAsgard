using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class Feature
    {
        [JsonProperty("i")]
        public int I { get; set; }

        [JsonProperty("land")]
        public bool Land { get; set; }

        [JsonProperty("border")]
        public bool Border { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("cells")]
        public int Cells { get; set; }

        [JsonProperty("firstCell")]
        public int FirstCell { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }
    }
}
