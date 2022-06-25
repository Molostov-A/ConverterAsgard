using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class Coords
    {
        [JsonProperty("latT")]
        public int LatT { get; set; }

        [JsonProperty("latN")]
        public int LatN { get; set; }

        [JsonProperty("latS")]
        public int LatS { get; set; }

        [JsonProperty("lonT")]
        public int LonT { get; set; }

        [JsonProperty("lonW")]
        public int LonW { get; set; }

        [JsonProperty("lonE")]
        public int LonE { get; set; }
    }
}
