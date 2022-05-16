using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public static class Calculate                      //Projenin üzerine gel sağ tıla Buil et,class      Public    olmalı!!!!!
    {

        // üyeleri de sadece static olmalı!

        public static decimal Topla(decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal Cikar(decimal a, decimal b)
        {
            return a - b;
        }
        public static decimal Carp(decimal a, decimal b)
        {
            return a * b;
        }
        public static decimal Bol(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
