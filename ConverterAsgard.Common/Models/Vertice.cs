using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Vertice
    {

        [JsonPropertyName("p")]
        public float[] P { get; set; }

        [JsonPropertyName("v")]
        public float[] V { get; set; }

        [JsonPropertyName("c")]
        public float[] C { get; set; }
    }
}
