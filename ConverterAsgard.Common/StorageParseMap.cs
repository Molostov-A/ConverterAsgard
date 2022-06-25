using System.Collections.Generic;
using ConverterAsgard.Common.Parsing.Models;

namespace ConverterAsgard.Common
{
    public class StorageParseMap
    {
        private static JsonNewtonsoftProvider storage;
        private FullMap Map { get; set; }

        
        public StorageParseMap(string name, string path)
        {
            storage = new JsonNewtonsoftProvider(name, path);
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
