using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class ConversorDeMoeda
    {
        public static double IOF = 1.06;
        public static double Converter(double cot, double compra)
        {
            return cot * compra * IOF;
        }
    }
}
