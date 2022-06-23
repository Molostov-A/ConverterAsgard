using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Newtonsoft.Json;
using Newtonsoft;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;


namespace ConverterAsgard.Common
{
    public class JsonNewtonsoftProvider
    {
        private string path { get; }

        public JsonNewtonsoftProvider(string name)
        {
            path = Directory.GetCurrentDirectory() + @"\" + name + ".json";
        }

        public void Write<T>(T TObject)
        {
            //var json = JsonConvert.SerializeObject(TObject);
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            var json = System.Text.Json.JsonSerializer.Serialize(TObject, options);
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
