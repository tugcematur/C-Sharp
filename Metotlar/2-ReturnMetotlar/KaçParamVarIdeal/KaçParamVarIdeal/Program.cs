using System;

namespace KaçParamVarIdeal
{
    class Program
    {
        static void Main(string[] args)
        {


            decimal Tl = ConvertDecimal("Kaç Tl var");
            decimal dolar = ConvertDecimal("Kaç dolar var?");
            // decimal dolarTlKar = RateCalculate(dolar);
            decimal euro = ConvertDecimal("Kaç Euro var?");
            //decimal euroTlKar = RateCalculate(euro);





            //decimal toplam = dolarTlKar + euroTlKar + Tl;
            decimal toplam = RateCalculate(dolar) + RateCalculate(euro) + Tl;
            Yazdir(toplam);
        }

        private static void Yazdir(decimal toplam)
        {
            Console.WriteLine("ToplamPara:" + toplam);
        }

        private static decimal RateCalculate(decimal forex)
        {
            try
            {
                Console.WriteLine("Kuru Giriniz:");
                decimal kur = Convert.ToDecimal(Console.ReadLine());
                return kur * forex;
            }
            catch (Exception)
            {

                Console.WriteLine("Geçerli değer giriniz!");
                return RateCalculate(forex);
                // return 0;
            }

        }

        static decimal ConvertDecimal(string txt)
        {
            try
            {
                Console.WriteLine(txt);
                return Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Sayısal değer giriniz!");
                return ConvertDecimal(txt);
                // return 0;
            }


        }
    }
}
