using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main()
        {
            int s1 = 0, s2 = 0;



            /*  Console.Write("Birinci sayi :");

              try
              {

                  s1 = Convert.ToInt32(Console.ReadLine());
              }
              catch (Exception)
              {

                  Console.WriteLine("Lütfen sayısal değer giriniz");
                  Main();
              }

              Console.Write("İkinci sayi :");
              try
              {

                  s2 = Convert.ToInt32(Console.ReadLine());
              }
              catch (Exception)
              {

                  Console.WriteLine("Lütfen sayısal değer giriniz");
                  Main();
              }

              Console.WriteLine("Toplam :" + (s1 + s2));
              */
            try
            {
                char isKod;
                Console.Write("Birinci sayi :");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci sayi :");
                s2 = Convert.ToInt32(Console.ReadLine());
             //   Console.WriteLine("Toplam :" + (s1 + s2));
                
                Console.WriteLine("İşlem Kodu + - * /");
                isKod =Convert.ToChar( Console.ReadLine());


                switch(isKod)
                {
                    case '+':
                        Console.WriteLine("Sonuç :" + (s1 + s2));
                        break;
                    case '-':
                        Console.WriteLine("Sonuç:" + (s1 - s2));
                        break;
                    case '*':
                        Console.WriteLine("Sonuç:" + (s1 * s2));
                        break;
                    case '/':
                        Console.WriteLine("Sonuç :" + (double)s1 / s2);
                        break;
                    default:
                        Console.WriteLine("Geçersiz karakter !");
                        Main();
                        break;

                }


/*
                if(isKod=='+'  )
                    Console.WriteLine("Sonuç:" + (s1 + s2));
                if (isKod == '-')
                    Console.WriteLine("Sonuç :" + (s1 - s2));
                if (isKod == '*')
                    Console.WriteLine("Sonuç:" + (s1 * s2));
                if (isKod == '/')
                    Console.WriteLine("Sonuç :" +(double) s1 / s2);
                */
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Main();
            }



        }
    }
}
