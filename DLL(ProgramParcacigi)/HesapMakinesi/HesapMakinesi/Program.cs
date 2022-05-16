using System;
using Calculator;


namespace HesapMakinesi
{
    class Program  //Eğer kütüphanesini oluşturduğumuz programda(Calculator) değişiklik yaparsak ,o programda projenin üzerine gelip sağ tıklaayıp  build etmemiz yeterli.( .dll yi tekrar seçmemize gerek yok.)
    {               //Dependencies(Bağımlılıklar)-> Add Project Reference -> .dll seç

        static void Main(string[] args)
        {
           // Calculate cal = new Calculate();    Calculate sınıfını  static (heapte çalışır ve hızlı ) tanımlamazsak nesne oluşturmalıyız. Static olmayan veriler Stack'te durur.

            decimal x = 110;
            decimal y = 200;
            Console.WriteLine(Calculate.Topla(x,y));
            Console.WriteLine(Calculate.Cikar(x, y));
            Console.WriteLine(Calculate.Carp(x, y));
            Console.WriteLine(Calculate.Bol(x, y));

            /*
            Console.WriteLine(cal.Topla(x, y));
            Console.WriteLine(cal.Cikar(x, y));
            Console.WriteLine(cal.Carp(x, y));
            Console.WriteLine(cal.Bol(x, y));
            */
        }
    }
}
