﻿using System;

namespace ConverterAsgard.Common
{
    public class FullMap
    {
        public Info info { get; set; }
        public Settings settings { get; set; }
        public Coords coords { get; set; }
        public Cells cells { get; set; }
        public Vertices[] vertices { get; set; }
        public Biomes biomes { get; set; }
        public Notes[] notes { get; set; }
        public Bases[] nameBases { get; set; }
    }
}
