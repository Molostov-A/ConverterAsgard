using System;
using ConverterAsgard.Common;


namespace ConverterAsgardConsoleApp
{
    public class Program
    {
        private static string path = @"G:\Programming\C-Sharp\ConverterAsgard\Test_maps\Caia";
        private static string nameFile = "Caia Full 2022-06-25-12-28";
        private static StorageParseMap _storageParseMapTest = new(nameFile, path);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var map = _storageParseMapTest.GetMap();
            var numList = map.Vertices;
            //foreach (var num in numList)
            //{
            //    var numRes = num.I;
            //    if (numRes == 55)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}
            for (int i = 0; i < numList.Count; i++)
            {
                var vertex = numList[i];
                if (i == 1343)
                {
                    Console.WriteLine(numList[i].P[0]);
                }
            }
        }
    }
}
