using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Province
    {

        [JsonProperty("i")]
        public int I { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("center")]
        public int Center { get; set; }

        [JsonProperty("burg")]
        public int Burg { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("formName")]
        public string FormName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }


    }
}
