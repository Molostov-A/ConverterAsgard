using System;
using ConverterAsgard.Common;


namespace ConverterAsgardConsoleApp
{
    public class Program
    {

        private static StorageParseMap _storageParseMapTest = new("Meresia Minimal 2022-06-25-11-54");
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var map = _storageParseMapTest.GetMap();

            var num = _storageParseMapTest.GetMap();
            
            Console.WriteLine(num);
        }
    }
}
