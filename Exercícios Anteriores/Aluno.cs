using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Aluno
    {
        public string Nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }
    }
}
