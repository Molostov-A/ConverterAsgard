using System.Collections.Generic;
using ConverterAsgard.Common.Models;

namespace ConverterAsgard.Common
{
    public class Storage
    {
        private static JsonProvider storage;
        private FullMap Map { get; set; }

        
        public Storage(string name)
        {
            storage = new JsonProvider(name);
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
