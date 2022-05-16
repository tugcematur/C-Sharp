using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
           //  Fakulteler f = new Fakulteler();   // new lemeden de çağırğlabilir.
             Fakulteler f;                              
            f.Id = 1;
            f.FakulteAd = "Güzel Sanatlar";
            Console.WriteLine(f.FakulteAd);
        }
    }
}
