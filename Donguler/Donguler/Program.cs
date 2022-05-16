using System;

namespace Donguler
{
    class Program
    {
        static int[] sayilar = { 10, 15, 72, 37, 48 };
        static int sayac = 0;
        static int toplam = 0;
        static void Main(string[] args)
        {
            BaslikYaz("For Döngüsü");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
                toplam += sayilar[i];
            }
           
            ToplamYaz(toplam);
      

            
            BaslikYaz("Do While Döngüsü");
            do
            {

                Console.WriteLine(sayilar[sayac]);
                toplam += sayilar[sayac];
                sayac = sayac + 1;
            } while (sayac < sayilar.Length);

            ToplamYaz(toplam);

           
            BaslikYaz("While Döngüsü");

            while (sayac < sayilar.Length)
            {
                Console.WriteLine(sayilar[sayac]);
                toplam += sayilar[sayac];
                sayac = sayac += 1;
            }
            ToplamYaz(toplam);

            
            BaslikYaz("For Each Döngüsü");
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
                toplam += item;
            }
            ToplamYaz(toplam);
        }

        private static void BaslikYaz(string bas)
        {
            toplam = 0;
            sayac = 0;
            Console.WriteLine("_____________");
            Console.WriteLine(bas);
            Console.WriteLine("_____________");
        }

        private static void ToplamYaz(int top)
        {
            Console.WriteLine("*************");
            Console.WriteLine("Toplam:"+ top);
            Console.WriteLine("*************");
        }

    }
}
