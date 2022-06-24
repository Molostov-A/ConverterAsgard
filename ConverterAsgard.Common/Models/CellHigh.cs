using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class CellHigh
    {
        [JsonProperty("cells")]
        public List<Cell> cells { get; set; }

        private List<object> _featuresObject;

        [JsonProperty("features")]
        public List<object> FeaturesObject
        {
            get
            {
                return _featuresObject;
            }
            set
            {
                _featuresObject = value;
                Features = new List<Feature>();
                Features.Add(null);
                foreach (var obj in value)
                {
                    try
                    {
                        Features.Add(JsonConvert.DeserializeObject<Feature>(obj.ToString()));
                    }
                    catch { }
                }
            }
        }

        public List<Feature> Features { get; set; }

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
