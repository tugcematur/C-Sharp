using System;

namespace Scope1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine("X'in ilk değeri " + x);
            IkiyeKatla(x);
            Console.WriteLine("x'in metottan sonraki değeri"+ x);
        }

        private static void IkiyeKatla(int x)
        {
            x = x * 2;
            Console.WriteLine("x'in metot içi değeri " +x);
        }
    }
}
