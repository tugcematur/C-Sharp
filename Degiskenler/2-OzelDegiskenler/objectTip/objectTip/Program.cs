using System;

namespace objectTip
{
    class Program
    {
        static void Main(string[] args)
        {
            object onrenk = ConsoleColor.White;
           
            ConsoleColor arkarenk = ConsoleColor.Red;
           
            Console.ForegroundColor =(ConsoleColor) onrenk;
            Console.BackgroundColor = arkarenk;
            //  samil a;

            object x = 100;
            var y = 100.25m;

            object EH = true;

            x = (int)  x * 2;

            string ad = "Şamil";

            Console.WriteLine("Int :" + x);
            Console.WriteLine("Decimal:" + y);
            Console.WriteLine("Bool:" + EH);
            Console.WriteLine("string:" + ad);
        }
    }
}
