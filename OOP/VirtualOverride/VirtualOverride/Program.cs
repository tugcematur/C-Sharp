using System;

namespace VirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            //Base anahtar sözcüğü, türetilmiş bir sınıf içinden temel sınıfın üyelerine erişmek için kullanılır:


            A baseclass = new A();

            string name = baseclass.Name;


            B DerivedClass = new B();

            DerivedClass.Name
        }
    }
}
