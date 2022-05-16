using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDatam
{
    public static class NumberData                            //Maaş,KapiNo,
    {
      public static int GetNumber()
        {
            Random rnd = new Random();
            int maas = rnd.Next();
            return maas;
        }

        

    }
}
