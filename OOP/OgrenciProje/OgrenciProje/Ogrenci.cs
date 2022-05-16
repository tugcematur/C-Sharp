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

        public string Ad { get; set; }

        public string Soyad { get; set; }
        public char Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }

        public string Cadde { get; set; }

        public int KapiNo { get; set; }

        public string Ilce { get; set; }

        public string Şehir { get; set; }

        public int Maas { get; set; }

        public string GetTitle()
        {
            
            if (Cinsiyet == 'E')
            {
                return "Sn Bay" + Ad + " " + Soyad;
            }
            else
            {
                return "Sn Bayan" + Ad + " " + Soyad;
            }
        }

        public int GetAge()
        {
            DateTime today = DateTime.Now;
            int yas = today.Year - DogumTarihi.Year;
            DateTime DogumGunu = DogumTarihi.AddYears(yas);


            if(DogumGunu < today)
            {
                yas = yas + 1;
            }

            return yas;
          
        }


        public List<String> GetAdress ()
        {
            List<string> adr = new List<string>();
            adr.Add(Cadde);
            adr.Add((KapiNo).ToString());
            adr.Add(Ilce + "/" + Şehir);

            return adr;




        }
        public String GetAdress2()
        {
            return $"Şehir  {Şehir}\nKapı No {KapiNo}\nİlçe/Şehir {Ilce + Şehir }";
        }

        public string [] GetAdress3()
        {
            string[] adr = { Cadde, KapiNo.ToString(), Ilce + "/" + Şehir };
            return adr;
           
        }
    }
}
