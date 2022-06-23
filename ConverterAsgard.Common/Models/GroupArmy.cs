using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{

    public class GroupArmy
    {
        [JsonPropertyName("archers")]
        public string Archers { get; set; }

        [JsonPropertyName("cavalry")]
        public string Cavalry { get; set; }

        [JsonPropertyName("infantry")]
        public string Infantry { get; set; }

        [JsonPropertyName("artillery")]
        public string Artillery { get; set; }

        [JsonPropertyName("fleet")]
        public string Fleet { get; set; }
    }
}
