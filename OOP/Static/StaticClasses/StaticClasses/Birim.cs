using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class Birim
    {
        static List<string> BirimListe;
        
        public static List<string> Birimler()
        {
            BirimListe.Add("KG");
            BirimListe.Add("Litre");
            BirimListe.Add("Km");

            return BirimListe;

        }
    }
}
