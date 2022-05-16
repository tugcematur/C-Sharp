using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaProje
{
   public  class Program
    {
        static void Main(string[] args)
        {
            Musteri m = new Musteri();

            m.AnneSoyad1 = "SUSÜ";
            Console.WriteLine(m.AnneSoyad1);
            Console.ReadKey();
        }
    }
}
