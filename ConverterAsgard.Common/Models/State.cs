using System;
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
        public float Expansionism { get; set; }

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
        public float Urban { get; set; }

        [JsonProperty("rural")]
        public float Rural { get; set; }

        [JsonProperty("burgs")]
        public int Burgs { get; set; }

        [JsonProperty("area")]
        public int Area { get; set; }

        [JsonProperty("cells")]
        public int Cells { get; set; }

        [JsonProperty("neighbors")]
        public List<int> Neighbors { get; set; }

        [JsonProperty("campaigns")]
        public List<Campaign> Campaigns { get; set; }

        [JsonProperty("diplomacy")]
        public List<object> DiplomacyObjects
        {
            get
            {
                return _diplomacyObjects;
            }
            set
            {
                _diplomacyObjects = value;
                Diplomacy = new List<string>();
                foreach (var obj in value)
                {
                    try
                    {
                        Diplomacy = JsonConvert.DeserializeObject<List<string>>(obj.ToString());
                    }
                    catch
                    {
                        try
                        {
                            Diplomacy.Add(obj.ToString());
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }

        private List<object> _diplomacyObjects;

        public List<string> Diplomacy { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("formName")]
        public string FormName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("provinces")]
        public List<int> Provinces { get; set; }

        [JsonProperty("pole")]
        public List<float> Pole { get; set; }

        [JsonProperty("alert")]
        public float Alert { get; set; }

        [JsonProperty("military")]
        public List<Military> Military { get; set; }
    }
}
