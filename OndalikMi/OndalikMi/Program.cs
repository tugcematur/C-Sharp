using System;

namespace OndalikMi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi:");                      // str.Contains('1')
            string girdi = Console.ReadLine();
            bool isNumber = SayiKontrol(girdi);


            
        }
                                                            // 00.2    0.4554 10000.44544       a1244545          
        private static bool SayiKontrol(string girdi)
        {
            for (int i = 0; i < girdi.Length; i++)
            {

                char.IsNumber(Convert.ToChar( girdi.Substring(i,i+1)));

            }
           
           
        }
    }
}
