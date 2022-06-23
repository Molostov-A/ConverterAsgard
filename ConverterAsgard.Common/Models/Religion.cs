using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Religion
    {
        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("culture")]
        public int Culture { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("form")]
        public string Form { get; set; }

        [JsonPropertyName("deity")]
        public string Deity { get; set; }

        [JsonPropertyName("center")]
        public int Center { get; set; }

        [JsonPropertyName("origins")]
        public int[] Origins { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
