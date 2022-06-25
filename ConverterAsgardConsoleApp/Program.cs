using System;
using ConverterAsgard.Common;


namespace ConverterAsgardConsoleApp
{
    public class Program
    {

        private static Storage _storageTest = new("Ongyland Full 2022-06-21-23-53");
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var map = _storageTest.GetMap();

            var num = _storageTest.GetMap().Cells.States[1].Type;
            
            Console.WriteLine(num);
        }
    }
}
