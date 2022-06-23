using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Vertice
    {

        [JsonPropertyName("p")]
        public int[] P { get; set; }

        [JsonPropertyName("v")]
        public int[] V { get; set; }

        [JsonPropertyName("c")]
        public int[] C { get; set; }
    }
}
