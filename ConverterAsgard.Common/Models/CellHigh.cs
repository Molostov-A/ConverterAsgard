using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class CellHigh
    {
        [JsonProperty("cells")]
        public List<Cell> cells { get; set; }

        [JsonProperty("features")]
        public object[] FeaturesObject { get; set; }

        [JsonProperty("cultures")]
        public List<Culture> Cultures { get; set; }

        [JsonProperty("burgs")]
        public List<Burg> Burgs { get; set; }

        [JsonProperty("states")]
        public State[] States { get; set; }

        [JsonProperty("provinces")]
        public Province[] Provinces { get; set; }

        [JsonProperty("Religions")]
        public Religion[] Religions { get; set; }

        [JsonProperty("Rivers")]
        public List<River> Rivers { get; set; }

        [JsonProperty("markers")]
        public List<Marker> Markers { get; set; }
    }
}
