using System;
using ConverterAsgard.Common;


namespace ConverterAsgardConsoleApp
{
    public class Program
    {

        private static StorageParseMap _storageParseMapTest = new("Couria Full 2022-06-25-11-37 (2)");
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var map = _storageParseMapTest.GetMap();

            var num = _storageParseMapTest.GetMap().Cells.States[1].Type;
            
            Console.WriteLine(num);
        }
    }
}
