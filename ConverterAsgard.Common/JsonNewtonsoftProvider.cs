using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Newtonsoft.Json;


namespace ConverterAsgard.Common
{
    public class JsonNewtonsoftProvider
    {
        private string _path { get; }

        public JsonNewtonsoftProvider(string name, string path)
        {
            _path = path + @"\" + name + ".json";
        }

        public void Write<T>(T TObject)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            var json = System.Text.Json.JsonSerializer.Serialize(TObject, options);
            File.WriteAllText(_path, json);
        }

        public T Read<T>() where T : new()
        {
            T TObject = new T();
            try
            {
                var json = File.ReadAllText(_path);
                TObject = JsonConvert.DeserializeObject<T>(json);
            }
            catch (FileNotFoundException)
            {
            }
            return TObject;
        }
    }
}
