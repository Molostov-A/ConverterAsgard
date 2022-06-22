using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Options
    {
        public bool pinNotes { get; set; }
        public bool showMFCGMap { get; set; }
        public int[] winds { get; set; }
        public string stateLabelsMode { get; set; }
        public int year { get; set; }
        public string era { get; set; }
        public string eraShort { get; set; }
        public Army[] military { get; set; }
        public string mapName { get; set; }
        public bool hideLabels { get; set; }
        public string stylePreset { get; set; }
        public bool rescaleLabels { get; set; }
        public int urbanDensity { get; set; }
    }

    public class Army
    {
        public string icon { get; set; }
        public string name { get; set; }
        public double rural { get; set; }
        public double urban { get; set; }
        public int crew { get; set; }
        public int power { get; set; }
        public string type { get; set; }
        public int separate { get; set; }
    }
}
