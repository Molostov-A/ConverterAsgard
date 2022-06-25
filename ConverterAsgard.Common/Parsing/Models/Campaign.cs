using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class Campaign
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }
}
