using IleriKalitim.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriKalitim
{



    public class Temel : IInsan, IAdres // yazdıktan sonra using ekle sonra implement et
    {

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cadde { get; set; }
        public string Sokak { get; set; }
        public int KapiNo { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }
        public char Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }



        public List<string> Getadres()
        {
            List<string> adres = new List<string>();
            adres.Add(Cadde);
            adres.Add(Sokak);
            adres.Add(KapiNo.ToString());
            adres.Add($"{Ilce}/{Il}");
            return adres;
        }

        public int GetAge()
        {
            DateTime today = DateTime.Now;
            int yas = today.Year - DogumTarihi.Year;
            DateTime DogumGunu = DogumTarihi.AddYears(yas);

            if (DogumGunu < today)
            {
                yas += yas;
            }
            return yas;
        }

         public  string GetTitle() // virtual = metodun içeriği değişebilir
        {

            if (Cinsiyet == 'E')
            {
                return $"Sn Bay {Ad} {Soyad}";
            }
            else
            {
                return $"Sn Bayan {Ad} {Soyad}";
            }
        }

    }
}
