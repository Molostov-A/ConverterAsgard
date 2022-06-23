using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Culture
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("base")]
        public int Base { get; set; }

        [JsonPropertyName("shield")]
        public string Shield { get; set; }

        [JsonPropertyName("center")]
        public int Center { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("expansionism")]
        public double Expansionism { get; set; }

        [JsonPropertyName("origins")]
        public object[] Origins { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
