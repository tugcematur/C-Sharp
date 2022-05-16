using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciProje
{
    class Program
    {
        // Eğer değişkene sadece o sınıftan erişim sağlanmak isteniyorsa public deyimi yerine private deyimi kullanılır.

        static List<Ogrenci> olist = new List<Ogrenci>();    //GENERIC LIST               GLOBAL DEĞİŞKEN : Bütün sınıflardan erişilebilir.
       // static int secilenId;
       // static Ogrenci secilenOgrenci;
        //  static string cinsiyet;
        static int secim;

        static void Main()
        {
            // DLL ler (küçük program parçacığı) Rastgele data üretirler.

            //projeye sağ tıkla manage Nuget  Packages 'ı seç-> Browse ' a Fake Data yaz ve onu install et. References da gözükecek. DLL'ler aslında

           
            Doldur();
            Menu();

        }

        private static void Menu()
        {
            Console.WriteLine("1-Tüm Verileri Görüntüle");
            Console.WriteLine("2-Detay Görüntüle");
            Console.WriteLine("3-Yeni Öğrenci ");
            Console.WriteLine("4-Silme");
            Console.WriteLine("5-Güncelleme");
            Console.WriteLine("6-Arama");
            Console.WriteLine("7- Isme Göre Sıralama(A-Z)");
            Console.WriteLine("8- Isme Göre Sıralama(Z-A)");
            Console.WriteLine("Çıkış");
            Console.WriteLine();

            Console.Write("Secim:");


           secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1 || secim == 2 || secim == 3 || secim == 4 || secim == 5|| secim==6|| secim==7 || secim==8)
            {
                if (secim == 1)
                {
                   Yaz(olist);
                }
                else if (secim == 2)
                {
                    Detay();
                }
                else if (secim == 3)
                {
                    Ekle();
                }
                else if (secim == 4)
                {
                    Sil();
                }
                else if (secim == 5)
                {
                    Guncelle();
                }
                else if (secim == 6)
                {
                    Ara();
                }
                else if (secim == 7)
                {
                    SiralaAZ();
                }
                else if (secim == 8)
                {
                    SiralaZA();
                }

                Menu();
            }


            else
            {
                Console.WriteLine(" Çıkış için Enter'a Basın");
                Console.ReadKey();

            }
            Yaz(olist);

        }

        private static void SiralaZA()
        {
            var yolist = olist.OrderByDescending(x => x.Ad).ToList();                    //ToList();
            Yaz(yolist);
        }

        private static void SiralaAZ()
        {
            var yolist = olist.OrderBy(x => x.Ad).ToList();
            Yaz(yolist);
        }

        private static void Ara()
        {
            Console.WriteLine("Aramak istediğiniz isim");
            string ara = Console.ReadLine();
            var yolist = olist.Where(x => x.Ad.Contains(ara)|| x.Soyad.Contains(ara)).ToList();
            Yaz(yolist);
            
        }

        private static void Yaz(List<Ogrenci> olist)
        {
            Console.WriteLine("Id   Ad    Soyad");


            foreach (var item in olist)
            {
                Console.WriteLine(item.Id + " " + item.Ad + " " + item.Soyad);
            }
            // Console.ReadLine();
            ToplamYaz(olist);
            Menu();
        }

        private static void ToplamYaz(List<Ogrenci> olist)
        {
            //1.Yol
            /*
           int kisiSayisi = 0;
            int erkekSayisi = 0;
            int kadinSayisi = 0;
            int maasToplam = 0;
            int erkekMaasToplam = 0;
            int kadinMaasToplam = 0;


             foreach (var item in olist)
                {
                    kisiSayisi++;
                    maasToplam += item.Maas;

                    if (item.Cinsiyet == 'E')
                    {
                        erkekSayisi++;
                        erkekMaasToplam+=item.Maas;

                    }
                    else
                    {
                        kadinSayisi++;
                        kadinMaasToplam += item.Maas;
                    }

                }



                kisiSayisi = olist.Count;
                erkekSayisi = olist.Where(x => x.Cinsiyet == 'E').Count();
                kadinSayisi = olist.Where(x => x.Cinsiyet == 'K').Count();
                maasToplam = olist.Sum(x => x.Maas);
                erkekMaasToplam = olist.Where(x => x.Cinsiyet == 'E').Sum(x => x.Maas);
                kadinMaasToplam = olist.Where(x => x.Cinsiyet == 'K').Sum(x => x.Maas);
            */
            //2.Yol
            //bekle
            Console.WriteLine("-------TOPLAMLAR-------");
            Console.WriteLine($"Kadın Sayısı: {olist.Where(x => x.Cinsiyet == 'K').Count()}\nErkek Sayısı: {olist.Where(x => x.Cinsiyet == 'E').Count()}\nKişi Sayısı: {olist.Count}\n ");
            Console.WriteLine($"Kadın Maaş: {olist.Where(x => x.Cinsiyet == 'K').Sum(x => x.Maas)}\nErkek Maaş: {olist.Where(x => x.Cinsiyet == 'E').Sum(x => x.Maas)}\n -Toplam Maaş- {olist.Sum(x => x.Maas)}");
            Console.WriteLine("-------ORTALAMALAR-------");
           Console.WriteLine($"Ortalama Kadın Maaş: {olist.Where(x=>x.Cinsiyet=='K').Average(x=>x.Maas)}");
         Console.WriteLine($"Ortalama Erkek Maaş: {olist.Where(x => x.Cinsiyet == 'E').Average(x => x.Maas)}");
            Console.ReadLine();
        }
        private static Ogrenci OgrenciSec()
        {
            Console.WriteLine("Id ?");
             int  secilenId = Convert.ToInt32(Console.ReadLine());
          //  Ogrenci  secilenOgrenci = olist.Find(x => x.Id == secilenId);
          //  return secilenOgrenci;
            return olist.Find(x => x.Id == secilenId);
        }

        private static void Guncelle()
        {
            bilgiGir();
            Yaz(olist);

        }

        private static void bilgiGir()  /////////////////////////Kod Tekrarı önleniyor
        {
            string ad;
            string soyad;
            if(secim==5)//Güncelleme
            {
                Ogrenci yBilgi = OgrenciSec();
                Console.Write("Ad:");
                ad = Console.ReadLine();
                Console.Write("Soyad:");
                soyad = Console.ReadLine();
                yBilgi.Ad = ad;
                yBilgi.Soyad = soyad;

            }
            else if(secim==3)//Ekleme
            {
                Ogrenci yOgr = new Ogrenci ();   //   List Ogrenci tipinde listeye, Ogrenci tipinde değer ekleniyor.
                Console.Write("Ad:");
                ad = Console.ReadLine();
                Console.Write("Soyad:");
                soyad = Console.ReadLine();
                yOgr.Id = olist.Max(x => x.Id) + 1;      //OgrenciSayısı arttırılıyor
                yOgr.Ad = ad;
                yOgr.Soyad = soyad;
                olist.Add(yOgr);
            }
           
        }


      

        private static void Ekle() //Giriş
        {
            bilgiGir();    
            Yaz(olist);                           

        }

        private static void Sil()
        {
            Ogrenci secOgr = OgrenciSec();
            olist.Remove(secOgr);
            Yaz(olist);
        }


        private static void Detay()
        {

            Ogrenci secilenOgrenci = OgrenciSec();
          ///  secilenOgrenci = olist.Find(x => x.Id == secilenId);   /// seçilen öğrencinin propertyleri gelir.
            //Sn Bay Ad Soyad
            /*
            if (secilenOgrenci.Cinsiyet == 'K')
                cinsiyet = "Bayan";
            else if (secilenOgrenci.Cinsiyet == 'E')
                cinsiyet = "Bay";

            Console.WriteLine("Hoşgeldiniz Sn" + " " + cinsiyet + " " + secilenOgrenci.Ad + " " + secilenOgrenci.Soyad + "!");

            Console.WriteLine("Cadde :" + secilenOgrenci.Cadde);
            Console.WriteLine("Kapı No :" + secilenOgrenci.KapiNo);
            Console.WriteLine("Şehir:" + secilenOgrenci.Ilce + "/" + secilenOgrenci.Şehir);
            */
            Console.WriteLine();
            Console.WriteLine(secilenOgrenci.GetTitle() + "(" + secilenOgrenci.GetAge() + ")");
            /* foreach (var item in secilenOgrenci.GetAdress())
             {
                 Console.WriteLine(item);
             }
            */
            Console.WriteLine(secilenOgrenci.GetAdress2());

            Console.WriteLine();

        }

        private static void Doldur()
        {
            int cns;
            int yas;
            for (int i = 1; i <= 20; i++)
            {
                Ogrenci o = new Ogrenci();
                o.Ad = FakeData.NameData.GetFirstName();
                o.Soyad = FakeData.NameData.GetSurname();
                o.Cadde = FakeData.PlaceData.GetStreetName();
                cns = FakeData.NumberData.GetNumber(0, 2);


                if (cns == 0)
                {
                    o.Cinsiyet = 'E';

                }
                else
                    o.Cinsiyet = 'K';

                yas = FakeData.NumberData.GetNumber(18, 28);
                o.DogumTarihi = DateTime.Now.AddYears(yas * -1);
                o.Id = i;
                o.Ilce = FakeData.PlaceData.GetCounty();
                o.KapiNo = FakeData.NumberData.GetNumber(1, 100);
                o.Şehir = FakeData.PlaceData.GetCity();
                o.Maas = FakeData.NumberData.GetNumber(750, 1000);
                olist.Add(o);     // Bilgilere ulaşmak içi olist ' bakıyoruz.
            }

            Yaz(olist); //List Ogrenci tipinde değişken
        }
    }
}
