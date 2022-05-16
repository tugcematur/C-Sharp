using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitKalitim2
{
    public class Temel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public char Cinsiyet { get; set; }

        public DateTime DogumTarihi { get; set; }
        public Adres Adres { get; set; } //Temel constructor ı oluşturmalyız.


        public Temel()
        {
            Adres = new Adres();
        }


        public string GetTitle()
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

        public List<string> GetAdres()
        {
            List<string> adres = new List<string>();
            adres.Add(Adres.Cadde);
            adres.Add(Adres.Sokak);                                // Adres classı tipinde Adres değişkeni
            adres.Add(Adres.KapiNo.ToString());
            adres.Add($"{Adres.Ilce}/{Adres.Il}");
            return adres;
        }


        public void FullAdres()
        {
            foreach (var item in GetAdres())
            {
                Console.WriteLine(item);
            }
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

    }
}