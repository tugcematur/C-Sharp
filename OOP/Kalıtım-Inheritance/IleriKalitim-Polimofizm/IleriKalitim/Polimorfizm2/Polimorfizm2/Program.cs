using System;

namespace Polimorfizm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();

            o.Id = 1;
            o.Ad = "Tuğçenur";
            o.Soyad = "Matur";
            Console.WriteLine(o); // string isteyen bir yerde otomatik olarak ToString metodu devreye girer.,
        }
    }
}
