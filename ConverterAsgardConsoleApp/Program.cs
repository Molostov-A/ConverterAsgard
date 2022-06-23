using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using ConverterAsgard.Common;
using ConverterAsgard.Common.Models;

namespace ConverterAsgardConsoleApp
{
    internal class Program
    {
        private static Storage _storageTest = new("map");
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var map = _storageTest.GetMap();
            //var biomes = new Biomes();
            //biomes.I = new List<int>();
            //biomes.I.Add(1);
            //map.Biomes = biomes;
            //_storageTest.Update(map);
            var num = _storageTest.GetMap().Notes[0].Id;
            Console.WriteLine(num);
        }
    }
}
