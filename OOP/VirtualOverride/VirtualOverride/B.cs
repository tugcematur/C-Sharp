using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    public class B : A
    {
        public override void ClassName()

        {

            Console.WriteLine("B: Class");

        }

        public override string Name
        {
            get
            {
                return base.Name;
            }

            set
            {
                base.Name = "test";
            }
        }

    }


    
}