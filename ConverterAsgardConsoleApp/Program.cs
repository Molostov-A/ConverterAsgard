using System;
using ConverterAsgard.Common;


namespace ConverterAsgardConsoleApp
{
    public class Program
    {

        private static Storage _storageTest = new("map");
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var map = _storageTest.GetMap();

            var num = _storageTest.GetMap().Cells.States[1].Type;
            
            Console.WriteLine(num);
        }
    }
}
