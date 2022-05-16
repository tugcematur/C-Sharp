using System;

namespace KacParamvarYapisal
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
                Console.WriteLine("Dolar Kuru");
                int kurd = Convert.ToInt32(Console.ReadLine());
                int doltlKar = dol * kurd;
                Console.WriteLine("Kaç Euro var?");
                int eur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Euro Kuru");
                int kure = Convert.ToInt32(Console.ReadLine());
                int eurtlKar = dol * kure;
                int toplamTl = Tl + eurtlKar + doltlKar;
                Console.WriteLine("Toplam Para :" + toplamTl);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Main(null);
            }

    

        }
    }
}
