using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciProje
{
    class Ogrenci
    {
        public int Id { get; set; } 
        public string Ad{ get; set; }
        public string  Soyad { get; set; }
        public char  Cins  { get; set; }
        public DateTime DogumTarih { get; set; }
        public string  Cadde { get; set; }   //ADRES BİLGİLERİ
        public int KapiNo { get; set; }
        public string  Sehir  { get; set; }
        public string  Ilce  { get; set; }
        public int Maas { get; set; }  //MAAŞ
        public string GetTitle()
        {
            if (Cins =='E')
            {
                return "Sn Bay " + Ad + " " + Soyad;
            }
            else
            {
                return "Sn Bayan " + Ad + " " + Soyad;
            }
        }
        public int  GetAge ()
        {
            DateTime today = DateTime.Now;
            int yas = today.Year - DogumTarih.Year;
            // 12 Agustos
            // yas = 25
            // Yas = 26
            DateTime DogumGunu = DogumTarih.AddYears(yas);
            if (DogumGunu < today)
            {
                yas = yas + 1;
            }
            return yas;

        }
        public List<String > GetAdres()
        {

            List<string> adr = new List<string>(); 
            adr.Add(Cadde);
            adr.Add(KapiNo.ToString());
            adr.Add(Ilce + "/" + Sehir);
            return adr;
        }
        public String GetAdres2()
        {
            return $"  Şehir  { Sehir}\n No {KapiNo}\n " +
                $"{Ilce + Sehir} ";
           
        }
        public string[]  GetAdres3()
        {
            string[] adr = { Cadde, KapiNo.ToString(), Ilce + "%" + Sehir };
            return adr;
           
        }
    }
}
