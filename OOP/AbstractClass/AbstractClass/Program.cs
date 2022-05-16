using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dhesapla = new Dikdortgen(); //
            dhesapla.AlanHesapla(2,4); // 8
            dhesapla.CevreHesapla(2,4); // 12


            Kare khesapla = new Kare();
            khesapla.AlanHesapla(5,5);     //25
            khesapla.CevreHesapla(5, 5); //20
        }
    }


    //1 - Abstract metodlar, sadece Abstract classlar içerisinde tanımlanabilir.
    //2 - Abstract metodlar, Virtual olarak tnaımlanamazlar.
    //3 - Abstract metodlar, Static olarak tanımlanamazlar.
    //    Statik kavramı, Class özelliği yada metodu olduğu için instance çıkarmaya gerek yoktur. Halbu ki, Statik olmayan metotlar, instance metotlarıdır. Abstract bir class ta,
    //    abstract olmayan static bir metod tanımlanabiliyorken, miras alındığı class ta implemente edilme zorunluluğu olduğundan, Abstract metodlar static olarak tanımlanamazlar.
    //4 - Abstrac metodların gövdesi olamaz. Çünkü onlar sadece miras alındığı class larda implement edilebilir.



    //char(50)  ->  dediğimizde bu kolonumuza char tipi veri girebiliriz ve
    //kolona kaç karakter girersek girelim her bir veri için 50 karakterlik yer ayrılır.

    // VarChar tipindeki Var ifadesi variable yani değişken olduğunu bildiriyor.
    //Mesela VarChar(50) dediğimizde bu kolona 50 karakter girebiliriz ancak girdiğimiz veri 50 karakterden az ise verinin boyutu kadar yer tutar. 


    // NVarChar değişkeninin mantığı ise VarChar ile aynıdır. İsmindeki N uNicode ifadesindeki N’dir. (***) VarChar’dan farkı ise bu kolonlarda Unicode karakterler tutulabilir.
    // Yani veritabanında birden fazla dilde karakter bulunduran alanlar olacaksa bu tipte kolon oluşturmanız sorun yaşamanıza engel olacaktır.
    //Nchar’da da benzeri bir durum var.
    // N’nin “National” anlamında

    public abstract class Hesaplamalar
    {

        public abstract void AlanHesapla(double a1, double b1);
        public abstract void CevreHesapla(double a2, double b2);

        decimal sayi1 = 12.3m;   // decimal değişkeni (-7.9 x 1028 to 7.9 x 1028) / (100 to 28) (28 basamak)  arasında değer depolayabilmektedir. 
                                 //veya 12.3M  , decimal türündeki değişkenler 128 bitlik (16 byte) gerçek sayı depolarlar.
                                 //Biz virgüllü bir sayıyı decimal olarak tanımladığımızı sonuna gerekli eklemeyi yaptıktan sonra belirtiriz.
                                 //decimal değişkenine yaptığımız tam sayı atamalarında sonuna ekleme yapmamıza gerek yoktur.  

        double sayi2 = 123.04;  // double türündeki değişkenler 64 bitlik (8 byte) gerçek sayı depolarlar. 
        double sayi3 = -123;   // double değişkeni 1.7E +/- 308 (15 basamak)  arasında değer depolayabilmektedir. 
                               //Hesaplamalarda, karmaşık işlemlerde kullanabiliriz


        float sayi4 = 12.34f; // float türündeki değişkenler 32 bitlik (4 byte) gerçek sayı depolarlar.
                              // float değişkeni tanımladığımızda eğer içerisine tam sayı olmayan bir değer atamak
                              // istediğimizde sayısının sonuna F veya f koyarak türünün float olduğunu belirtmemiz gerekmektedir
                              //Bunun sebebi C# ortamında noktalı sayıların varsayılan değeri double’dır. 
        float sayi5 = 2345;   //Float değişkenine yaptığımız tam sayı atamalarında sonuna ekleme yapmamıza gerek yoktur.


        ulong sayi6 = 1234567890123;  //  ulong türündeki değişkenler 64 bitlik (8 byte) işaretli veri depolarlar.
                                      //ulong değişkeni 0 ve 18,446,744,073,709,551,615 arasında değer depolayabilmektedir.

        long sayi7 = -123123123123;    //
                                       //    long değişkeni –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 arasında değer depolayabilmektedir.

        int sayi8 = -123450;           // int türündeki değişkenler 32 bitlik işaretli veri depolarlar. 
                                       //  İnt değişkeni -2.147.483.648 ile 2.147.483.647 arasında değer depolayabilmektedir.
        int sayi9 = 123456789;       //Tam sayı değer tutması veri aralığının geniş olması sebebiyle en sık kullandığımız değişken türüdür.
    }



     class Kare : Hesaplamalar
    {
        public override void AlanHesapla(double a1, double b1)
        {
            Console.WriteLine("Kare Alan : {0}",a1*b1);
        }

        public override void CevreHesapla(double a2, double b2)
        {
            Console.WriteLine( "Kare Çevre:"+ (4*a2));
        }
    }

    class Dikdortgen : Hesaplamalar
    {
        public override void AlanHesapla(double kısakenar, double uzunkenar)  
        {
            Console.WriteLine("Dikdörtgen Alan:"+ kısakenar * uzunkenar);
        }

        public override void CevreHesapla(double kısakenar, double uzunkenar)
        {
            Console.WriteLine("Dikdörtgen Çevre:"+2*(kısakenar + uzunkenar ) );
        }
    }
}
