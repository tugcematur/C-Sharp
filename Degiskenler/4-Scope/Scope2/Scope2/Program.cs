using System;

namespace Scope2
{


   
        class Program
        {
             static  int x = 0;
            static void Main(string[] args)
            {
                x = 100;
                Console.WriteLine("X'in ilk değeri " + x);
                IkiyeKatla(x);
                Console.WriteLine("x'in metottan sonraki değeri" + x);
            }

            private static void IkiyeKatla(int x)
            {
                x = x * 2;
                Console.WriteLine("x'in metot içi değeri " + x);
            }
        }
   

}
