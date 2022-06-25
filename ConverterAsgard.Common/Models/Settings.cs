using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConverterAsgard.Common.Models
{
    public class Settings
    {
        [JsonProperty("distanceUnit")]
        public string DistanceUnit { get; set; }

        [JsonProperty("distanceScale")]
        public string DistanceScale { get; set; }

        [JsonProperty("areaUnit")]
        public string AreaUnit { get; set; }

        [JsonProperty("heightUnit")]
        public string HeightUnit { get; set; }

        [JsonProperty("heightExponent")]
        public string HeightExponent { get; set; }

        [JsonProperty("temperatureScale")]
        public string TemperatureScale { get; set; }

        [JsonProperty("barSize")]
        public string BarSize { get; set; }

        [JsonProperty("barLabel")]
        public string BarLabel { get; set; }

        [JsonProperty("barBackOpacity")]
        public string BarBackOpacity { get; set; }

        [JsonProperty("barBackColor")]
        public string BarBackColor { get; set; }

        [JsonProperty("barPosX")]
        public string BarPosX { get; set; }

        [JsonProperty("barPosY")]
        public string BarPosY { get; set; }

        [JsonProperty("populationRate")]
        public int PopulationRate { get; set; }

        [JsonProperty("urbanization")]
        public int Urbanization { get; set; }

        [JsonProperty("mapSize")]
        public string MapSize { get; set; }

        [JsonProperty("latitudeO")]
        public string LatitudeO { get; set; }

        [JsonProperty("temperatureEquator")]
        public string TemperatureEquator { get; set; }

        [JsonProperty("temperaturePole")]
        public string TemperaturePole { get; set; }

        [JsonProperty("prec")]
        public string Prec { get; set; }

        [JsonProperty("options")]
        public Options Options { get; set; }

        [JsonProperty("mapName")]
        public string MapName { get; set; }

        [JsonProperty("hideLabels")]
        public bool HideLabels { get; set; }

        [JsonProperty("stylePreset")]
        public string StylePreset { get; set; }

        [JsonProperty("rescaleLabels")]
        public bool RescaleLabels { get; set; }

        [JsonProperty("urbanDensity")]
        public int UrbanDensity { get; set; }
    }
}
