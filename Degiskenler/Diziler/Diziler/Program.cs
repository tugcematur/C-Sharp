using System;
using System.Linq;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10,20,25,7,66 };
            Console.WriteLine(sayilar.Length);
            Console.WriteLine(sayilar[2]);
            Console.WriteLine(sayilar.Max());
            Console.WriteLine(sayilar.Min());
            Console.WriteLine(sayilar.Sum());
            Console.WriteLine(sayilar.Average());
            Console.WriteLine( sayilar.Count());


            string[] aylar = { "Ocak", "Şubat", "Mart" };
            Console.WriteLine(aylar[0]);



        }
    }
}
