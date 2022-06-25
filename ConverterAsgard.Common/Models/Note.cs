using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Note
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("legend")]
        public string Legend { get; set; }
        
    }
}
