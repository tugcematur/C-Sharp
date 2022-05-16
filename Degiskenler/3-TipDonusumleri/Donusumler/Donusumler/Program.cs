using System;

namespace Donusumler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert
            int x = 100;
            string y = "200";

            int toplam = x + Convert.ToInt32(y);
            Console.WriteLine("Toplam= " +toplam);

            string a = "100";
            string b = "200";
            var top1 = b+ a;


            Console.WriteLine("top1:" +top1);

            //Cast
            object a1 = 100;
            int b1 = 200;
            int top2 =(int) a1 + b1;
            Console.WriteLine("Top2:"+ top2);


            //To.String() Metotsal
            long Tc = 39421415251;
            string ad = "Şamil";
            string soyad = "Yılmaz";

            string info = Tc + "" + ad + "" + soyad; // İstisna
            Console.WriteLine("Info" + info);


        }
    }
}
