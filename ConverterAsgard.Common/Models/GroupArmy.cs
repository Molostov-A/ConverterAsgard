using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{

    public class GroupArmy
    {
        [JsonProperty("archers")]
        public string Archers { get; set; }

        [JsonProperty("cavalry")]
        public string Cavalry { get; set; }

        [JsonProperty("infantry")]
        public string Infantry { get; set; }

        [JsonProperty("artillery")]
        public string Artillery { get; set; }

        [JsonProperty("fleet")]
        public string Fleet { get; set; }
    }
}
