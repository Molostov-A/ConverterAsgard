using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class Coords
    {
        [JsonProperty("latT")]
        public float LatT { get; set; }

        [JsonProperty("latN")]
        public float LatN { get; set; }

        [JsonProperty("latS")]
        public float LatS { get; set; }

        [JsonProperty("lonT")]
        public float LonT { get; set; }

        [JsonProperty("lonW")]
        public float LonW { get; set; }

        [JsonProperty("lonE")]
        public float LonE { get; set; }
    }
}
