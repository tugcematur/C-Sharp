using IleriKalitim.Classes;
using System;

namespace IleriKalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            o.Id = 1;
            o.Ad = "Büşra";
            o.Sokak = "Ak";
            o.Bolum = "Makina Müh";
            o.Cadde = "Ayvansaray Caddesi";
            o.Cinsiyet = 'K';
            o.DogumTarihi = Convert.ToDateTime("01/01/1996");
            o.Ilce = "Kadıköy";
            o.Il = "Istanbul";
            o.Sokak = "Balat";
            o.KapiNo = 7;

            Console.WriteLine(o.GetTitle());
          
            Console.WriteLine(o.GetAge());
        }
    }
}
