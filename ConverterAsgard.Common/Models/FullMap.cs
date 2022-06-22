using System;

namespace ConverterAsgard.Common.Models
{
    public class FullMap
    {
        public Info info { get; set; }
        public Settings settings { get; set; }
        public Coords coords { get; set; }
        public CellsFolder CellsFolder { get; set; }
        public Vertices[] vertices { get; set; }
        public Biomes biomes { get; set; }
        public Notes[] notes { get; set; }
        public Bases[] nameBases { get; set; }
    }

}
