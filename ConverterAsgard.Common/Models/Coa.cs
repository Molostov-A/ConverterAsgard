using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Coa
    {
        [JsonProperty("t1")]
        public string T1 { get; set; }

        [JsonProperty("ordinaries")]
        public List<Ordinari> Ordinaries { get; set; }

        [JsonProperty("charges")]
        public Charge Charges { get; set; }

        [JsonProperty("shield")]
        public string Shield { get; set; }
    }
}
