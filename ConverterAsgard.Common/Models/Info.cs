using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterAsgard.Common.Models
{
    public class Info
    {
        public string version { get; set; }
        public string description { get; set; }
        public string exportedAt { get; set; }
        public string mapName { get; set; }
        public string seed { get; set; }
        public int mapId { get; set; }
    }
}
