using System;

namespace StringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Şamil";
            Console.WriteLine(ad.ToLower() );
            Console.WriteLine(ad.ToUpper());

            string str = "Gurultu";
            Console.WriteLine(str.Contains("ul"));
            Console.WriteLine(str.GetType());
            Console.WriteLine(str.IndexOf("u"));
            Console.WriteLine(str.Replace('u','ü'));

            object a = "50";
            a.ToString();

            string isim = "***Şamil***";
            Console.WriteLine(isim.Trim());
            Console.WriteLine(isim.TrimEnd('*'));
            
        }
    }
}
