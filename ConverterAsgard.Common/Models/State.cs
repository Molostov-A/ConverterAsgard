using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class State
    {
        [JsonProperty("i")]
        public int I { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expansionism")]
        public double Expansionism { get; set; }

        [JsonProperty("capital")]
        public int Capital { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("Center")]
        public int Center { get; set; }

        [JsonProperty("culture")]
        public int Culture { get; set; }


        [JsonProperty("coa")]
        public Coa Coa { get; set; }

        [JsonProperty("urban")]
        public int Urban { get; set; }

        [JsonProperty("rural")]
        public double Rural { get; set; }

        [JsonProperty("burgs")]
        public int Burgs { get; set; }

        [JsonProperty("area")]
        public int Area { get; set; }

        [JsonProperty("cells")]
        public int[] Cells { get; set; }

        [JsonProperty("neighbors")]
        public int[] Neighbors { get; set; }

        [JsonProperty("campaigns")]
        public List<Campaign> Campaigns { get; set; }

        [JsonProperty("diplomacy")]
        public string[] Diplomacy { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("formName")]
        public string FormName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("provinces")]
        public int[] Provinces { get; set; }

        [JsonProperty("pole")]
        public List<double> Pole { get; set; }

        [JsonProperty("alert")]
        public double Alert { get; set; }

        [JsonProperty("military")]
        public List<Military> Military { get; set; }
    }
}
