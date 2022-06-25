using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class Ordinari
    {
        [JsonProperty("ordinary")]
        public string Ordinary { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }
    }

}
