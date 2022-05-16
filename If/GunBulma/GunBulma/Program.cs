using System;

namespace GunBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaçıncı gündeyiz?");
            int gun = Convert.ToInt32(Console.ReadLine());
            
            
            if (gun == 1)
                Console.WriteLine("Bugün Pazartesi");
            else if(gun == 2){

                Console.WriteLine("Bugün Salı");
            }

            else if (gun == 3)
            {

                Console.WriteLine("Bugün Çarşamba ");
            }
            else if (gun == 4)
            {

                Console.WriteLine("Bugün Perşembe");
            }

            else if (gun == 5)
            {

                Console.WriteLine("Bugün Cuma");
            }

            else if (gun == 6)
            {

                Console.WriteLine("Bugün Cumartesi");
            }

            else if (gun == 7)
            {

                Console.WriteLine("Bugün Pazar");
            }


            else
            {
                Console.WriteLine("Yanlış gün girdiniz");
                Main(null);
                Console.ReadLine();
            }
        }
    }
}
