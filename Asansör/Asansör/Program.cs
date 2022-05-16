using System;
using System.Collections;

namespace Asansör
{
    class Program
    {
        static void Main(string[] args)
        {
        //Bellekte 1 ile 100 arasında sayı tutsun . Tahmin de bulunucaz. 5 adet hakkı var.

        Gir:
            int tutulan;
            int tahmin;
            int sayac = 0;
            int hak = 5;

        
            Random rnd = new Random();

            tutulan = rnd.Next(1, 101);


            Console.WriteLine("Sayi={0}", tutulan);

      
            while (sayac <= 4 && sayac >= 0)
            {
                string onay;
          

                Console.Write("Sayı girin=");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > tutulan)
                {
                    Console.WriteLine("Sayıyı azalt");
                    hak--;
                    Console.WriteLine("Kalan hakkınız:{0}", hak);
                   


                }


                else if (tahmin < tutulan)
                {

                    Console.WriteLine("Sayıyı arttır");
                    hak--;
                    Console.WriteLine("Kalan hakkınız:{0}", hak);
              
                

                }





                else
                {
                    sayac++;
                    Console.WriteLine("Tebrikler {0}. hakkınızda bildiniz", sayac);

                    Console.WriteLine("Tekrar oynamak istiyor musunuz?");
                    Console.WriteLine("E/H ");

                    onay = Console.ReadLine().ToString();
                    switch (onay)
                    {
                        case "E":
                            goto Gir;

                        case "H":
                            break;
                        default:
                            Console.WriteLine("Geçersiz ");
                            break;


                    }

               
                    break;



                }


                if (hak == 0 )
                {
                    Console.WriteLine("Tekrar oynamak istiyor musunuz?");
                    Console.WriteLine("E/H ");

                    onay = Console.ReadLine().ToString();
                    switch (onay)
                    {
                        case "E":
                            goto Gir;

                        case "H":
                            break;
                        default:
                            Console.WriteLine("Geçersiz ");
                            break;


                    }

                    break;
                }
                if (hak == 0 )
                    break;
            }



        }
    }
}

//CTRL +K +U     Geri Alma
  






