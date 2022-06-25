using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Army
    {
        public string icon { get; set; }
        public string name { get; set; }
        public float rural { get; set; }
        public float urban { get; set; }
        public int crew { get; set; }
        public int power { get; set; }
        public string type { get; set; }
        public int separate { get; set; }
    }
}
