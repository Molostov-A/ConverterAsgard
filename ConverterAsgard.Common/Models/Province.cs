using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Province
    {

        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("center")]
        public int Center { get; set; }

        [JsonPropertyName("burg")]
        public int Burg { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("formName")]
        public string FormName { get; set; }

        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }


    }
}
