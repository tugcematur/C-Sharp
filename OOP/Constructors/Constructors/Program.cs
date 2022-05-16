using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            //Ogrenci o1 = new Ogrenci(2);
            o.Id = 1;
            o.Soyad = "Yıldız";
            o.Ad = "Şamil";
            Console.WriteLine(o.KayitTarihi);
        }
    }
}
