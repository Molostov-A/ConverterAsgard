using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Charge
    {
        [JsonPropertyName("charge")]
        public string ChargeFild { get; set; }

        [JsonPropertyName("t")]
        public string T { get; set; }

        [JsonPropertyName("p")]
        public string P { get; set; }

        [JsonPropertyName("size")]
        public double Size { get; set; }
    }
}
