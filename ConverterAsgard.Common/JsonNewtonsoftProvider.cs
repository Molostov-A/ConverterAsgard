using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Newtonsoft.Json;
using Newtonsoft;


namespace ConverterAsgard.Common
{
    public class JsonNewtonsoftProvide
    {
        private string path { get; }

        public JsonNewtonsoftProvide(string name)
        {
            path = Directory.GetCurrentDirectory() + @"\" + name + ".json";
        }

        public void Write<T>(T TObject)
        {
            var json = JsonConvert.SerializeObject(TObject);
            File.WriteAllText(path, json);
        }

        public T Read<T>() where T : new()
        {
            T TObject = new T();
            try
            {
                var json = File.ReadAllText(path);
                TObject = JsonConvert.DeserializeObject<T>(json);
            }
            catch (FileNotFoundException)
            {
            }
            return TObject;
        }
    }
}
