using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{

    public class River
    {
        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("source")]
        public int Source { get; set; }

        [JsonPropertyName("mouth")]
        public int Mouth { get; set; }

        [JsonPropertyName("discharge")]
        public int Discharge { get; set; }

        [JsonPropertyName("length")]
        public double Length { get; set; }

        [JsonPropertyName("width")]
        public double Width { get; set; }

        [JsonPropertyName("widthFactor")]
        public double WidthFactor { get; set; }

        [JsonPropertyName("sourceWidth")]
        public int SourceWidth { get; set; }

        [JsonPropertyName("parent")]
        public int Parent { get; set; }

        [JsonPropertyName("cells")]
        public int[] Cells { get; set; }
    }
}
