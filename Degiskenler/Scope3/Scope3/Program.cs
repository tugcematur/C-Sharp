using System;

namespace Scope3
{
    class Program
    {
         static int x = 0;
        static void Main(string[] args)
        {
          int  x = 100;
            Console.WriteLine("X'in ilk değeri " + x);
            IkiyeKatla();
            Console.WriteLine("x'in metottan sonraki değeri" + x);
        }

        private static void IkiyeKatla()
        {
            x = x * 2;
            Console.WriteLine("x'in metot içi değeri " + x);
        }
    }
}
