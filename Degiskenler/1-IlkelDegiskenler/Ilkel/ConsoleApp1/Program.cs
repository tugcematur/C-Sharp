using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            decimal y = 100.25m;

            bool EH = true;

            x = x * 2;

            string ad = "Şamil";

            Console.WriteLine("Int :"+x);
            Console.WriteLine("Decimal:" +y);
            Console.WriteLine("Bool:"  +EH);
            Console.WriteLine("string:" +ad);
        }
    }
}
