using System;

namespace Kapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m = new Musteri();
            m.Id = 1;
            m.Ad = "Şamil";
            m.Id = 1;
            m.KartNo1 = "1234567890";
            m.Soyad = "Yılmaz";

            Console.WriteLine($"{m.Ad} {m.Soyad}\n Kart No: {m.KartNo1}");


            Personel p = new Personel();

            p.Id = 1;
            p.Ad1 = "tuğçenur";
            p.Soyad1 = "matur";

            Console.WriteLine($"Ad: {p.Ad1} Soyad: {p.Soyad1}");

        }
    }
}
