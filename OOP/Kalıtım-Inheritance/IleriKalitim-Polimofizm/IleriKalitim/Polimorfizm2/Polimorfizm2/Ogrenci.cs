﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm2
{
    public  class Ogrenci
    {
        public int Id { get; set; }
        public string Ad{ get; set; }
        public string Soyad { get; set; }

        public override string ToString()  
        {
            return Ad + " " + Soyad;
        }
    }
}
