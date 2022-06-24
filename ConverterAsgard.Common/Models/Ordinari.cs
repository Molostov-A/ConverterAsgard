using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Ordinari
    {
        [JsonProperty("ordinary")]
        public string Ordinary { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }
    }

}
