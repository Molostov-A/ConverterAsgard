using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Coa
    {
        [JsonPropertyName("t1")]
        public string T1 { get; set; }

        [JsonPropertyName("ordinaries")]
        public List<Ordinari> Ordinaries { get; set; }

        [JsonPropertyName("charges")]
        public Charge Charges { get; set; }

        [JsonPropertyName("shield")]
        public string Shield { get; set; }
    }
}
