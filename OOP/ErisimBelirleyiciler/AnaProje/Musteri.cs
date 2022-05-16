using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaProje
{
    public class Musteri
    {
        public int Id { get; set; }
        private string Ad { get; set; }
        public string Soyad { get; set; }
         private string AnneSoyad;
      // private string AnneSoyad { get; set; }
        protected string KKN { get; set; }
         public string AnneSoyad1 { get => AnneSoyad; set => AnneSoyad = value; }


       protected string AnneSoyadGetir()    
        {
            return "*****" + AnneSoyad.Substring(AnneSoyad.Length - 2);
        }

      
        public string KKNGetir()
        {
            return KKN;
        }
    }
}