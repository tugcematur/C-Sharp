using IleriKalitim.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriKalitim.Classes
{
    public class Egitmen : Temel, IEgitmen

    {
        public decimal  Maas{ get; set; }
        public decimal MaasHesapla()
        {
            return Maas * .75m;
        }
    }
}
