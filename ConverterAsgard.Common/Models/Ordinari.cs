using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Ordinari
    {
        [JsonPropertyName("ordinary")]
        public string Ordinary { get; set; }

        [JsonPropertyName("t")]
        public string T { get; set; }
    }

}
