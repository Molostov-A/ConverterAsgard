using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class Vertice
    {

        [JsonProperty("p")]
        public float[] P { get; set; }

        [JsonProperty("v")]
        public float[] V { get; set; }

        [JsonProperty("c")]
        public float[] C { get; set; }
    }
}
