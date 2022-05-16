using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
   public class Personel
    {
        public int Id { get; set; }
        public string Ad1 { get => Ad; set => Ad = value.Substring(0,1).ToUpper() + value.Substring(1).ToLower();  }
        public string Soyad1 { get => Soyad; set => Soyad = value.ToUpper(); }

        private string Ad;
        private string Soyad;
    }
}
