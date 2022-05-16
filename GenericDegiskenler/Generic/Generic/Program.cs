using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Diziler -1");
            Console.WriteLine("2-Diziler -2");
            Console.WriteLine("3-Array List");
            Console.WriteLine("4- Generic -1");
            Console.WriteLine("5- Generic -2");
            Console.WriteLine("6- Generic -3");
            Console.WriteLine("7- Generic -4");


            string secim = Console.ReadLine();
            Secim(secim);
            
        }

        private static void Secim(string secim)
        {
            if (secim=="1")
            {
                Dizi1();
            }

            else if(secim=="2")
            {
                Dizi2();
            }

            else if(secim=="3")
            {
                Alist1();
            }

            else if(secim=="4")
            {
                Generic1();
            }

            else if (secim == "5")
            {
                Generic2();
            }

            else if (secim == "6")
            {
                Generic3();
            }
            else if (secim=="7")
            {
                Generic4();
            }
            Main(null);
            
        }

        private static void Generic4()
        {
            List<ConsoleColor> col = new List<ConsoleColor>(); 
            col.Add(ConsoleColor.DarkRed);                             // Tipi Enum
            col.Add(ConsoleColor.Gray);
            col.Add(ConsoleColor.Yellow);
            col.Add(ConsoleColor.Blue);
            col.Add(ConsoleColor.Magenta);

            foreach (var item in col)
            {   
                
                Console.BackgroundColor = item;
                Console.WriteLine(item);
            }

        }

        private static void Generic3()
        {
            List<object> esnek = new List<object>(); // List int tipinde
            esnek.Add("Elma");
            esnek.Add("Portakal");
            esnek.Add("Kiwi");
            esnek.Add(100);
            

            foreach (var item in esnek)
            {
                Console.WriteLine(item);
            }
        }

        private static void Generic1() //          Tip korumalı
        {
            List<int> sayilar = new List<int>(); // List int tipinde
            sayilar.Add(10);
            sayilar.Add(20);
            sayilar.Add(30);
            // sayilar.Add("Portakal");
            //  sayilar.Remove(30);
            //  sayilar.RemoveAt(1);

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
        }


        private static void Generic2() //          Tip korumalı
        {
            List<string> meyveler = new List<string>(); // List int tipinde
            meyveler.Add("Elma");
            meyveler.Add("Portakal");
            meyveler.Add("Kiwi");

            foreach (var item in meyveler)
            {
                Console.WriteLine(item);
            }
        }

        private static void Dizi1()
        {
            Console.WriteLine("Dizi -1");
            int[] sayilar = { 10, 20, 30, 40 };
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            
            
        }
        private static void Dizi2()
        {
            Console.WriteLine("Dizi -2");
            string[] meyveler = { "Elma", "Armut", "Kiraz" };

            foreach (var item in meyveler)
            {
                Console.WriteLine(item);
            }
           
        }
        private static void Alist1()
        {
            Console.WriteLine("Alist -1");
            ArrayList alist = new ArrayList();        //Tip korumasız olduğu için hatalara açık,toplama işlemi gibi...
            alist.Add(10);
            alist.Add(20);
            alist.Add("Portakal");
            alist.Add("Ocak");
            alist.Remove("Ocak");
            alist.RemoveAt(1); // Birinci elemanı siler.

            foreach (var item in alist)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
