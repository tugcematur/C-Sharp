using System;

namespace HesapMakinası
{
    class Program
    {
       static decimal s1 = 0;
       static  decimal s2 = 0;
        static void Main(string[] args)
        {
             s1 = Cevir("Birinci sayıyı girin:");
             s2 = Cevir("İkinci sayıyı girin");
            string iskod = Islem();
            decimal sonuc = Hesapla(iskod,s1,s2);
       //     Console.WriteLine(s1 + " "+ s2 + " "+ iskod);
            
            Yazdir(sonuc);
        }

        private static void Yazdir(decimal sonuc)
        {
            if(sonuc==0 && s2==0)
                Console.WriteLine("Error");
            else
            Console.WriteLine("Sonuc:" + sonuc);

            Main(null);
        }

        private static decimal Hesapla(string iskod,decimal s1, decimal s2)
        {
            decimal sonuc = 0;
            if (iskod == "+")
                sonuc = Topla(s1, s2);
            else if (iskod == "*")
                sonuc = Carp(s1, s2);
            else if (iskod == "-")
                sonuc = Cikar(s1, s2);
            else if (iskod == "/")

                if(s2!=0)
                sonuc = Bol(s1, s2);

            return sonuc;
        }

        private static decimal Bol(decimal s1, decimal s2)
        {
          return s1/ s2;   
            
        }

        private static decimal Cikar(decimal s1, decimal s2)
        {
            return s1 - s2;
        }

        private static decimal Carp(decimal s1, decimal s2)
        {
            return s1 * s2;
        }

        private static decimal Topla(decimal s1 ,decimal s2)
        {
            return s1 + s2;
        }

        private static string Islem()
        {


            Console.WriteLine("İşlem kodunu giriniz + - * /");
            string Ikod = Console.ReadLine();

            if (Ikod == "+" || Ikod == "-" || Ikod == "*" || Ikod == "/")
            {
                return Ikod;
            }
            else

                Console.WriteLine("Yanlış işlem kodu!");
            return Islem();
        }

        private static decimal Cevir(string txt)
        {

            try
            {
                Console.WriteLine(txt);
                return Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Hatalı giriş yaptınız, Lütfen doğru değer girin!");
                return Cevir(txt);
            }


        }
    }
}
