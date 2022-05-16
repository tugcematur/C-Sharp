using IleriKalitim.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriKalitim.Classes
{
     public class Ogrenci:Temel,IOgrenci
    {
        public string Bolum { get; set; }
        public int Not { get; set; }
        public string NotHesapla()
        {
            if (Not >= 45)
            {
                return "Geçti";
            }
            else
                return "Kaldı";
        }
    }
}
