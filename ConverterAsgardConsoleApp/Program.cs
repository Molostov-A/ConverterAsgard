using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using ConverterAsgard.Common;
using ConverterAsgard.Common.Models;
using Newtonsoft.Json;


namespace ConverterAsgardConsoleApp
{
    public class Program
    {
        List<Feature> Features(List<object> FeaturesObject)
        {
            var FeaturesTrue = new List<Feature>();
            foreach (var obj in FeaturesObject)
            {
                string text = obj.ToString();
                try
                {
                    dynamic result = JsonConvert.DeserializeObject(text);

                    //var result = JsonConvert
                    //    .DeserializeAnonymousType(text, new {samples = default(List<Feature>)})
                    //    .samples;
                    FeaturesTrue.Add(result);
                }
                catch { }
            }

            return FeaturesTrue;
        }

        private static Storage _storageTest = new("map1");
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var map = _storageTest.GetMap();

            var num = _storageTest.GetMap().Cells;


            num = _storageTest.GetMap().Cells;
            Console.WriteLine(num);
        }
    }
}
