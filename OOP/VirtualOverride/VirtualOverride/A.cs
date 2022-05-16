using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    //Virtual olarak tanımladığımız metodlarımızı, diğer class larda override edebiliriz.

    // Sadece metod isimlerini belirteceğimiz bir classımız olsun, metodların ne işlev yapacağını diğer classlarda belirtecek isek Virtual metod kullanırız.
    //Birden çok Class larımızın, aynı anlama gelen metodları varsa, bu metodu Virtual olarak tanımlarız.
    //Yazılımda standartlaşmak önemlidir, eğer geliştirilen uygulamamızın farklı modüllerinde, metod isimlerimizin aynı olması isteniyorsa, yine Virtual metod kullanırız.

    /*********************************************************************************************************************************************************************/


    // AbstractClass lar, sadece base class olarak davranmasını(yani inherit edilebilmesi) ve kendisinden instance çıkartılmamasını istediğimiz durumlarda kullanılır.

    /* Abstract Classların en büyük özelliği, içerisinde Abstract olan yada olmayan metodları barındırabilmesidir.Abstract metotlar, kalıtım aldığı 
         class ta inplement edilerek kullanılacak metotlardır yani tanımlandığı yerlerde herhangi bir kod bloğu bulundurmazlar.*/

    //*Abstract metodlar sadece Abstract Class larda tanımlanabilirler.
    //Abstract metodlar, private olarak tanımlanamazlar.
    //Abstract metodlar, private olarak tanımlanamazlar.
    //Abstract metodlar, Static olarak tanımlanamazlar. Statik kavramı, Class özelliği yada metodu olduğu için instance çıkarmaya gerek yoktur.
    //Abstrac metodların gövdesi olamaz. 


    /********************************************************************************************************************************************************************/

    //Static Class'lar sadece statik üye içerebilirler.

 
    public class A
    {
        public   virtual  string Name {get; set; }


        public virtual void ClassName()

        {

            Console.WriteLine("A: Class");

        }
    }
}
