using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime KayitTarihi { get; set; }

      
        public Ogrenci()
        {
            Console.WriteLine("Yapıcı Çalıştı.");
            
        }

        /*
        public Ogrenci(int z)
        {
            Console.WriteLine("Yapıcı2 Çalıştı.");

        }

        */

    }
}
