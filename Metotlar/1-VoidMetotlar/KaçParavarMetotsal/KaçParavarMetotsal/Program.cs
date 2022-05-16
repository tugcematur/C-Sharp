using System;

namespace KaçParavarMetotsal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Kaç TL var?");
                int Tl = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Kaç Dolar var?");
                int dol = Convert.ToInt32(Console.ReadLine());

                DolarHesapla(dol, Tl);




            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Main(null);
            }

        }

        static void DolarHesapla(int dol, int tl)
        {
            Console.WriteLine("Dolar Kuru");
            int kurd = Convert.ToInt32(Console.ReadLine());
            int tlkar = kurd * dol;
            int toplam = tlkar + tl;
            Console.WriteLine($"Toplam Param: {toplam} TL");
        }
    }
}
