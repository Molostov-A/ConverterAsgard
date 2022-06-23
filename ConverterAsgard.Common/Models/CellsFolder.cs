using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConverterAsgard.Common.Models
{
    public class CellsFolder
    {
        [JsonPropertyName("cells")]
        public List<Cell> Cells { get; set; }

        [JsonPropertyName("features")]
        public List<Feature> Features { get; set; }

        [JsonPropertyName("cultures")]
        public List<Culture> Cultures { get; set; }

        [JsonPropertyName("burgs")]
        public List<Burg> Burgs { get; set; }

        [JsonPropertyName("states")]
        public State[] States { get; set; }

        [JsonPropertyName("provinces")]
        public Province[] Provinces { get; set; }

        [JsonPropertyName("religions")]
        public Religion[] religions { get; set; }

        [JsonPropertyName("rivers")]
        public List<River> rivers { get; set; }

        [JsonPropertyName("markers")]
        public List<Marker> Markers { get; set; }
    }

    public class Marker
    {
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("dx")]
        public int Dx { get; set; }

        [JsonPropertyName("px")]
        public int Px { get; set; }

        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }

        [JsonPropertyName("cell")]
        public int Cell { get; set; }

        [JsonPropertyName("i")]
        public int I { get; set; }
    }

    public class River
    {
        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("source")]
        public int Source { get; set; }

        [JsonPropertyName("mouth")]
        public int Mouth { get; set; }

        [JsonPropertyName("discharge")]
        public int Discharge { get; set; }

        [JsonPropertyName("length")]
        public double Length { get; set; }

        [JsonPropertyName("width")]
        public double Width { get; set; }

        [JsonPropertyName("widthFactor")]
        public double WidthFactor { get; set; }

        [JsonPropertyName("sourceWidth")]
        public int SourceWidth { get; set; }

        [JsonPropertyName("parent")]
        public int Parent { get; set; }

        [JsonPropertyName("cells")]
        public int[] Cells { get; set; }
    }

    public class Religion
    {
        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("culture")]
        public int Culture { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("form")]
        public string Form { get; set; }

        [JsonPropertyName("deity")]
        public string Deity { get; set; }

        [JsonPropertyName("center")]
        public int Center { get; set; }

        [JsonPropertyName("origins")]
        public int[] Origins { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }
    }

    public class Province
    {

        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("center")]
        public int Center { get; set; }

        [JsonPropertyName("burg")]
        public int Burg { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("formName")]
        public string FormName { get; set; }

        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }


    }

    public class Charge
    {
        [JsonPropertyName("charge")]
        public string ChargeFild { get; set; }

        [JsonPropertyName("t")]
        public string T { get; set; }

        [JsonPropertyName("p")]
        public string P { get; set; }

        [JsonPropertyName("size")]
        public double Size { get; set; }
    }

    public class Ordinari
    {
        [JsonPropertyName("ordinary")]
        public string Ordinary { get; set; }

        [JsonPropertyName("t")]
        public string T { get; set; }
    }

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

    public class Campaign
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("end")]
        public int End { get; set; }
    }

    public class Military
    {
        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("a")]
        public int A { get; set; }

        [JsonPropertyName("cell")]
        public int cell { get; set; }

        [JsonPropertyName("x")]
        public int X { get; set; }

        [JsonPropertyName("y")]
        public int Y { get; set; }

        [JsonPropertyName("bx")]
        public int bx { get; set; }

        [JsonPropertyName("by")]
        public int by { get; set; }

        [JsonPropertyName("u")]
        public GroupArmy U { get; set; }

        [JsonPropertyName("n")]
        public int N { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("icon")]
        public string icon { get; set; }
    }

    public class GroupArmy
    {
        [JsonPropertyName("archers")]
        public string Archers { get; set; }

        [JsonPropertyName("cavalry")]
        public string Cavalry { get; set; }

        [JsonPropertyName("infantry")]
        public string Infantry { get; set; }

        [JsonPropertyName("artillery")]
        public string Artillery { get; set; }

        [JsonPropertyName("fleet")]
        public string Fleet { get; set; }
    }

    public class Burg
    {
        [JsonPropertyName("cell")]
        public int cell { get; set; }

        [JsonPropertyName("x")]
        public double X { get; set; }

        [JsonPropertyName("y")]
        public double Y { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("culture")]
        public int Culture { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("feature")]
        public int Feature { get; set; }

        [JsonPropertyName("capital")]
        public int Capital { get; set; }

        [JsonPropertyName("port")]
        public int Port { get; set; }

        [JsonPropertyName("population")]
        public double Population { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("coa")]
        public Coa Coa { get; set; }

        [JsonPropertyName("citadel")]
        public int Citadel { get; set; }

        [JsonPropertyName("plaza")]
        public int Plaza { get; set; }

        [JsonPropertyName("walls")]
        public int Walls { get; set; }

        [JsonPropertyName("shanty")]
        public int Shanty { get; set; }

        [JsonPropertyName("temple")]
        public int Temple { get; set; }
    }

    public class Culture
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("base")]
        public int Base { get; set; }

        [JsonPropertyName("shield")]
        public string Shield { get; set; }

        [JsonPropertyName("center")]
        public int Center { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("expansionism")]
        public double Expansionism { get; set; }

        [JsonPropertyName("origins")]
        public object[] Origins { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }
    }

    public class Feature
    {
        [JsonPropertyName("i")]
        public int I { get; set; }

        [JsonPropertyName("land")]
        public bool Land { get; set; }

        [JsonPropertyName("border")]
        public bool Border { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("cells")]
        public int Cells { get; set; }

        [JsonPropertyName("firstCell")]
        public int FirstCell { get; set; }

        [JsonPropertyName("group")]
        public string Group { get; set; }
    }

    public class Cell
    {
        public int i { get; set; }
        public int[] v { get; set; }
        public int[] c { get; set; }
        public double[] p { get; set; }
        public int g { get; set; }
        public int h { get; set; }
        public int area { get; set; }
        public int f { get; set; }
        public int t { get; set; }
        public int haven { get; set; }
        public int harbor { get; set; }
        public int fl { get; set; }
        public int r { get; set; }
        public int conf { get; set; }
        public int biome { get; set; }
        public int s { get; set; }
        public int pop { get; set; }
        public int culture { get; set; }
        public int burg { get; set; }
        public int road { get; set; }
        public int crossroad { get; set; }
        public int state { get; set; }
        public int religion { get; set; }
        public int province { get; set; }
    }
}
