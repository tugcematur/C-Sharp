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
            o.Soyad = "Ak";
            o.Bolum = "Makina Müh";
            o.Cadde = "Ayvansaray Caddesi";
            o.Cinsiyet = 'K';
            o.DogumTarihi = Convert.ToDateTime("01/01/1996");
            o.Ilce = "Kadıköy";
            o.Il = "Istanbul";
            o.Sokak = "Balat";
            o.KapiNo = 7;
            Console.WriteLine("Ogrenci Bilgileri");
            Console.WriteLine("____________________");
         
            Console.WriteLine(o.GetTitle());

            foreach (var item in o.Getadres())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(o.GetAge());


            Console.WriteLine( "Akademisyen Bilgileri");
            Console.WriteLine("____________________");
            Egitmen e = new Egitmen();
            e.Id = 1;
            e.Ad = "Şamil";
            e.AkademikUnvan = "Doç. Dr.";
            e.Soyad = "Yılmaz";
            e.Cadde = "Ayvansaray Caddesi";
             e.Cinsiyet = 'K';
            e.DogumTarihi = Convert.ToDateTime("01/01/1996");
            e.Ilce = "Kadıköy";
            e.Il = "Istanbul";
            e.Sokak = "Balat";
            e.KapiNo = 7;
            Console.WriteLine(e.GetTitle());

            foreach (var item in e.Getadres())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(e.GetAge());


        }
    }
}
