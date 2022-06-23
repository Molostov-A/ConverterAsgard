using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class State
    {
        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("expansionism")]
        public double Expansionism { get; set; }

        [JsonPropertyName("capital")]
        public int Capital { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("Center")]
        public int Center { get; set; }

        [JsonPropertyName("culture")]
        public int Culture { get; set; }


        [JsonPropertyName("coa")]
        public Coa Coa { get; set; }

        [JsonPropertyName("urban")]
        public int Urban { get; set; }

        [JsonPropertyName("rural")]
        public double Rural { get; set; }

        [JsonPropertyName("burgs")]
        public int Burgs { get; set; }

        [JsonPropertyName("area")]
        public int Area { get; set; }

        [JsonPropertyName("cells")]
        public int[] Cells { get; set; }

        [JsonPropertyName("neighbors")]
        public int[] Neighbors { get; set; }

        [JsonPropertyName("campaigns")]
        public List<Campaign> Campaigns { get; set; }

        [JsonPropertyName("diplomacy")]
        public string[] Diplomacy { get; set; }

        [JsonPropertyName("form")]
        public string Form { get; set; }

        [JsonPropertyName("formName")]
        public string FormName { get; set; }

        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("provinces")]
        public int[] Provinces { get; set; }

        [JsonPropertyName("pole")]
        public List<double> Pole { get; set; }

        [JsonPropertyName("alert")]
        public double Alert { get; set; }

        [JsonPropertyName("military")]
        public List<Military> Military { get; set; }
    }
}
