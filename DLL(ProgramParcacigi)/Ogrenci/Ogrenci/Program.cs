using System;
using System.Collections.Generic;
using FakeDatam;

namespace Ogrenci
{
    class Program
    {
        
        static List<Ogrenci> olist = new List<Ogrenci>();
       
        static void Main()
        {
            
            Ogrenci o = new Ogrenci();

            
            o.Ad = FakeDatam.NameData.GetName();
            o.Soyad = FakeDatam.NameData.GetSurname();
            FullName();
            

        }

        public static string FullName()
        {
            foreach (var item in olist)
            {
               string fn= item.Id + " " + item.Ad + " " + item.Soyad;
            }
            return FullName();
        }

    }
}
