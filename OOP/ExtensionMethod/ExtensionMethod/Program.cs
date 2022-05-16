using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "mustafa";

            DateTime bugun = DateTime.Now;
            string s= "2021002";

            Console.WriteLine(ad.IlkHarfBuyuk());
            Console.WriteLine(bugun.ToJulian());
            Console.WriteLine(bugun);

        }
    }
}
