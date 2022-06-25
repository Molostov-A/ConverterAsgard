using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{

    public class River
    {
        [JsonProperty("i")]
        public int I { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }

        [JsonProperty("mouth")]
        public int Mouth { get; set; }

        [JsonProperty("discharge")]
        public int Discharge { get; set; }

        [JsonProperty("length")]
        public float Length { get; set; }

        [JsonProperty("width")]
        public float Width { get; set; }

        [JsonProperty("widthFactor")]
        public float WidthFactor { get; set; }

        [JsonProperty("sourceWidth")]
        public int SourceWidth { get; set; }

        [JsonProperty("parent")]
        public int Parent { get; set; }

        [JsonProperty("cells")]
        public List<int> Cells { get; set; }
    }
}
