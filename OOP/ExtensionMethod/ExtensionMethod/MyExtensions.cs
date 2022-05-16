using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static  class MyExtensions   // neden static?
    {
        //ToString() metoduna ek özellik kazandırıcaz.  Extensionslar da  ' this ' kullanılır

        public static  string  IlkHarfBuyuk(this String txt) // Neden static?              // ToString() metodu gibi davranacak
        {
           return  txt.Substring(0, 1).ToUpper() + txt.Substring(1);
        }

        //2021001   1 Ocak
        //2021002   2 Ocak
        //2022365   31 Aralık

        public static int ToJulian (this DateTime d)
        {
            int yil = d.Year*1000;
            int gun = d.DayOfYear ;
            yil = yil +  gun;

            return yil;
        }

        /*
        public static DateTime ToDate (this int x)
        {
           
        }

        */

    }
}
