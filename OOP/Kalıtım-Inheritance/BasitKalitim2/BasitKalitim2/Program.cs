using System;

namespace BasitKalitim2
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci o = new Ogrenci();
            o.Id = 1;      
            o.Ad = "Büşra";
            o.Soyad= "Ak";                       //Adres özelliği Ogrenci class'ının Temel classtan kalıtım alması sayesinde çağırılabilir.
            o.Bolum = "Makina Müh";
            o.Cinsiyet = 'K';
            o.DogumTarihi = Convert.ToDateTime("01/01/1996");
           // Adres a = new Adres();
            o.Adres.Cadde = "Ayvansaray Caddesi"; // Adres özelliği  hata veriyor,çünkümAdres classı new lenmedi.
            o.Adres.Ilce = "Kadıköy";
            o.Adres.Il = "Istanbul";
            o.Adres.Sokak = "Balat";
            o.Adres.KapiNo = 7;

            Console.WriteLine(o.GetTitle());
            o.FullAdres();
            Console.WriteLine(o.GetAge());

        }
    }
}
