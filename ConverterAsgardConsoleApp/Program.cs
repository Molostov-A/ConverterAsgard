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

            var num = _storageTest.GetMap().Cells.Religions[2].Name;
            Console.WriteLine(num);
        }
    }
}
