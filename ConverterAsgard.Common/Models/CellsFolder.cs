namespace ConverterAsgard.Common.Models
{
    public class CellsFolder
    {
        public Cell[] cells { get; set; }
        public object[] features { get; set; }
        public Culture[] cultures { get; set; }
        public Burg[] burgs { get; set; }
        public State[] states { get; set; }
        public Province[] provinces { get; set; }
        public Religion[] religions { get; set; }
        public River[] rivers { get; set; }
        public Marker[] markers { get; set; }
    }

    public class Marker
    {
    }

    public class River
    {
    }

    public class Religion
    {
    }

    public class Province
    {
    }

    public class State
    {
    }

    public class Burg
    {
    }

    public class Culture
    {
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
