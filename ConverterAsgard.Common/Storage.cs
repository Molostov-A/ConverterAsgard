using System.Collections.Generic;
using ConverterAsgard.Common.Models;

namespace ConverterAsgard.Common
{
    public class Storage
    {
        private static JsonNewtonsoftProvide storage;
        private FullMap Map { get; set; }

        
        public Storage(string name)
        {
            storage = new JsonNewtonsoftProvide(name);
            Map = storage.Read<FullMap>();
        }

        public FullMap GetMap()
        {
            return Map;
        }

        public void Update(FullMap result)
        {
            Map = result;
            Save();
        }

        private void Save()
        {
            storage.Write(Map);
        }
    }
}
