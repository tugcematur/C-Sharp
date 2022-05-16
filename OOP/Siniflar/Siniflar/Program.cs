using System;

namespace Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci.X = 1; // static değişkeni çağırıyoruz
            Ogrenci o1 = new Ogrenci(); // Statik olmayan değişkeni çağırıyoruz
            o1.Id = 1;
            o1.Ad = "Büşra";                               //set işlemi
            o1.Soyad = "Ak";

            Ogrenci o2 = new Ogrenci();
            o2.Id = 1;
            o2.Ad = "Hilal";
            o2.Soyad = "Türker";


            Console.WriteLine(o1.Ad + " " + o1.Soyad);
            Console.WriteLine(o2.Ad + " " + o2.Soyad);
        }
    }
}
