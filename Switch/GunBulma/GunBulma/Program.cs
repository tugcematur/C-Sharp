using System;

namespace GunBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
              //  decimal b = 0.0m;
               // decimal a = 10/b ; 

                Console.WriteLine("Bugün hangi gün?");
                int gun = Convert.ToInt32(Console.ReadLine());

                switch (gun)
                {
                    case 1:
                        Console.WriteLine("Pazartesi");
                        break;
                    case 2:
                        Console.WriteLine("Salı");
                        break;
                    case 3:
                        Console.WriteLine("Çarşamba");
                        break;
                    case 4:
                        Console.WriteLine("Perşembe");
                        break;
                    case 5:
                        Console.WriteLine("Cuma");
                        break;
                    case 6:
                        Console.WriteLine("Cumartesi");
                        break;
                    case 7:
                        Console.WriteLine("Pazar");
                        break;

                    default:
                        Console.WriteLine("Yanlış sayı girdiniz");
                        Main(null);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               // Console.WriteLine( "Sayısal değer  girin !");
                Console.Read();
                Main(null);
            }
            
        }
    }
}
