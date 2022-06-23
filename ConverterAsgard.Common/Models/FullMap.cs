using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConverterAsgard.Common.Models
{
    public class FullMap
    {
        [JsonPropertyName("info")]
        public Info Info { get; set; }

        [JsonPropertyName("settings")]
        public Settings Settings { get; set; }

        [JsonPropertyName("coords")]
        public Coords Coords { get; set; }

        [JsonPropertyName("CellsFolder")]
        public CellsFolder CellsFolder { get; set; }

        [JsonPropertyName("vertices")]
        public List<Vertice> Vertices { get; set; }

        [JsonPropertyName("Biomes")]
        public Biomes Biomes { get; set; }

        [JsonPropertyName("notes")]
        public List<Note> Notes { get; set; }

        [JsonPropertyName("nameBases")]
        public List<Bases> NameBases { get; set; }
    }

}
