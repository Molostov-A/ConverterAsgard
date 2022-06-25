using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class CellHigh
    {
        [JsonProperty("cells")]
        public List<Cell> CellsProperty { get; set; }

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
        private List<object> _featuresObject;

        public List<Feature> Features { get; set; }


        [JsonProperty("cultures")]
        public List<Culture> Cultures { get; set; }

        [JsonProperty("burgs")]
        public List<Burg> Burgs { get; set; }

        [JsonProperty("states")]
        public List<State> States { get; set; }

        [JsonProperty("provinces")]
        public List<object> ProvincesObject
        {
            get
            {
                return _provincesObject;
            }
            set
            {
                _provincesObject = value;
                Provinces = new List<Province>();
                Provinces.Add(null);
                foreach (var obj in value)
                {
                    try
                    {
                        Provinces.Add(JsonConvert.DeserializeObject<Province>(obj.ToString()));
                    }
                    catch { }
                }
            }
        }

        private List<object> _provincesObject;
        public List<Province> Provinces { get; set; }

        [JsonProperty("Religions")]
        public List<Religion> Religions { get; set; }

        [JsonProperty("Rivers")]
        public List<River> Rivers { get; set; }

        [JsonProperty("markers")]
        public List<Marker> Markers { get; set; }
    }
}
