﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Parsing.Models
{
    public class Culture
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("i")]
        public int I { get; set; }

        [JsonProperty("base")]
        public int Base { get; set; }

        [JsonProperty("shield")]
        public string Shield { get; set; }

        [JsonProperty("center")]
        public int Center { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("expansionism")]
        public float Expansionism { get; set; }

        [JsonProperty("origins")]
        public List<object> Origins { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
