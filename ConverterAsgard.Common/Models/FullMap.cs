using System;

namespace ConverterAsgard.Common.Models
{
    public class FullMap
    {
        public Info info { get; set; }
        public Settings settings { get; set; }
        public Coords coords { get; set; }
        public CellsFolder CellsFolder { get; set; }
        public Vertice[] vertices { get; set; }
        public Biomes Biomes { get; set; }
        public Notes[] notes { get; set; }
        public Bases[] nameBases { get; set; }
    }

}
