using System;

namespace AyveYKHesap
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hangi aydayız?");
                int ay = Convert.ToInt32(Console.ReadLine());
                

                if (ay 0<= 12 && ay>0)
                {

                    Console.WriteLine("Hangi yarım küredeyiz?");
                    string ykure =(Console.ReadLine()).ToString();
                    switch (ykure)
                    {
                        case "k":
                            if (ay == 12 || ay == 1 || ay == 2)
                                Console.WriteLine("Kış");
                            if (ay == 3 || ay == 4 || ay == 5)
                                Console.WriteLine("İlkbahar");
                            if (ay == 6 || ay == 7 || ay == 8)
                                Console.WriteLine("Yaz");
                            if (ay == 9 || ay == 10 || ay == 11)
                                Console.WriteLine("Sonbahar");
                            break;
                        case "g":

                            if (ay == 12 || ay == 1 || ay == 2)
                                Console.WriteLine("Yaz");
                            if (ay == 3 || ay == 4 || ay == 5)
                                Console.WriteLine("Sonbahar");
                            if (ay == 6 || ay == 7 || ay == 8)
                                Console.WriteLine("Kış");
                            if (ay == 9 || ay == 10 || ay == 11)
                                Console.WriteLine("İlkbahar");
                            break;
                        default:
                            Console.WriteLine("Girdiğiniz değer hatalı!");
                            Main(null);
                            break;
                    }

                   
                }

                else
                {

                    Console.WriteLine("Ay bilgisi geçersiz!!");
                    Main(null);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                // Console.WriteLine( "Sayısal değer  girin !");
              //  Console.Read();
                Main(null);
            }
        }
    }
}
