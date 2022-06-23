using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConverterAsgard.Common.Models
{
    public class Cells
    {
        [JsonPropertyName("cells")]
        public List<Cell> cells { get; set; }

        [JsonPropertyName("features")]
        public List<Feature> Features { get; set; }

        [JsonPropertyName("cultures")]
        public List<Culture> Cultures { get; set; }

        [JsonPropertyName("burgs")]
        public List<Burg> Burgs { get; set; }

        [JsonPropertyName("states")]
        public State[] States { get; set; }

        [JsonPropertyName("provinces")]
        public Province[] Provinces { get; set; }

        [JsonPropertyName("religions")]
        public Religion[] religions { get; set; }

        [JsonPropertyName("rivers")]
        public List<River> rivers { get; set; }

        [JsonPropertyName("markers")]
        public List<Marker> Markers { get; set; }
    }
}
