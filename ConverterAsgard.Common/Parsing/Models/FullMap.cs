﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class FullMap
    {
        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("coords")]
        public Coords Coords { get; set; }

        [JsonProperty("cells")]
        public CellHigh Cells { get; set; } // ячейки

        [JsonProperty("vertices")]
        public List<Vertice> Vertices { get; set; }  // вершины

        [JsonProperty("Biomes")]
        public Biomes Biomes { get; set; }

        [JsonProperty("notes")]
        public List<Note> Notes { get; set; }

        [JsonProperty("nameBases")]
        public List<Bases> NameBases { get; set; }
    }

}
