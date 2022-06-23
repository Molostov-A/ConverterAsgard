using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Burg
    {
        [JsonPropertyName("cell")]
        public int cell { get; set; }

        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("culture")]
        public int Culture { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("feature")]
        public int Feature { get; set; }

        [JsonPropertyName("capital")]
        public int Capital { get; set; }

        [JsonPropertyName("port")]
        public int Port { get; set; }

        [JsonPropertyName("population")]
        public double Population { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("coa")]
        public Coa Coa { get; set; }

        [JsonPropertyName("citadel")]
        public int Citadel { get; set; }

        [JsonPropertyName("plaza")]
        public int Plaza { get; set; }

        [JsonPropertyName("walls")]
        public int Walls { get; set; }

        [JsonPropertyName("shanty")]
        public int Shanty { get; set; }

        [JsonPropertyName("temple")]
        public int Temple { get; set; }
    }

}
