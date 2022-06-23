using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Military
    {
        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("a")]
        public int A { get; set; }

        [JsonPropertyName("cell")]
        public int cell { get; set; }

        [JsonPropertyName("x")]
        public int X { get; set; }

        [JsonPropertyName("y")]
        public int Y { get; set; }

        [JsonPropertyName("bx")]
        public int bx { get; set; }

        [JsonPropertyName("by")]
        public int by { get; set; }

        [JsonPropertyName("u")]
        public GroupArmy U { get; set; }

        [JsonPropertyName("n")]
        public int N { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("icon")]
        public string icon { get; set; }
    }
}
