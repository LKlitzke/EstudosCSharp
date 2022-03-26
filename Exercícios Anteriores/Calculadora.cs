using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Calculadora
    {
        public static int Soma(params int[] num)
        {
            int soma = 0;
            for(int i = 0; i < num.Length; i++)
            {
                soma += num[i];
            }
            return soma;
        }
    }
}
