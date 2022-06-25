using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class Vertice
    {

        [JsonProperty("p")]
        public float[] P { get; set; } // координаты х у

        [JsonProperty("v")]
        public float[] V { get; set; } // соприкасается с этими вершинами

        [JsonProperty("c")]
        public float[] C { get; set; } // соприкасается с этими ячейками
    }
}
