using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Empregado (int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double pct)
        {
            Salario += Salario * (pct / 100);
        }
        public override string ToString()
        {
            return Id + ", " + Nome + ", R$ " + Salario.ToString("F2");
        }
    }
}
