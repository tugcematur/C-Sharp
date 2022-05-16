using System;

namespace KahveGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Adınız:");
            string ad = Console.ReadLine();
            Console.WriteLine("Merhaba " + ad+ ",kaç yaşındasın?");
            int yas = Convert.ToInt32(Console.ReadLine());
            
            if(yas >= 18)
                // Console.WriteLine( "Kahveye hoşgeldin!" + ad);
                Console.WriteLine($"{ad} Kahveye hoşgeldin" );
            else
            {
               // Math.Abs(-10);

                int bekle = 18 - yas;
                //Console.WriteLine(ad + "Kahveye Giremezsin" + "Daha" +bekle+ "yıl  beklemen gerekir");
                Console.WriteLine($"{ad} Kahveye giremezsin, daha {bekle} yıl beklemen gerekiyor. " );
               
            }
            Console.ReadLine();
            Main(null);


        }
    }
}
