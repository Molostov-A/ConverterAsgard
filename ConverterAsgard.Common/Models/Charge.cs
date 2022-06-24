using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Charge
    {
        [JsonProperty("charge")]
        public string ChargeFild { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }

        [JsonProperty("p")]
        public string P { get; set; }

        [JsonProperty("size")]
        public double Size { get; set; }
    }
}
