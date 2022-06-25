using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Options
    {
        [JsonProperty("pinNotes")]
        public bool PinNotes { get; set; }

        [JsonProperty("showMFCGMap")]
        public bool ShowMFCGMap { get; set; }

        [JsonProperty("winds")]
        public List<int> Winds { get; set; }

        [JsonProperty("stateLabelsMode")]
        public string StateLabelsMode { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("era")]
        public string Era { get; set; }

        [JsonProperty("eraShort")]
        public string EraShort { get; set; }

        [JsonProperty("military")]
        public List<Army> Military { get; set; }

        [JsonProperty("mapName")]
        public string MapName { get; set; }

        [JsonProperty("hideLabels")]
        public bool HideLabels { get; set; }

        [JsonProperty("stylePreset")]
        public string StylePreset { get; set; }

        [JsonProperty("rescaleLabels")]
        public bool RescaleLabels { get; set; }

        [JsonProperty("urbanDensity")]
        public int UrbanDensity { get; set; }
    }
}
