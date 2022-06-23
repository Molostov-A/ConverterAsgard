using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Bases
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("min")]
        public int min { get; set; }

        [JsonPropertyName("max")]
        public int max { get; set; }

        [JsonPropertyName("d")]
        public string D { get; set; }

        [JsonPropertyName("m")]
        public float M { get; set; }

        [JsonPropertyName("b")]
        public string B { get; set; }
    }
}
