using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class ContaBancaria
    {
        public int Num { get; private set; }
        public string Nome { get; set; }
        public double Valor { get; private set; }

        public ContaBancaria(int num, string nome, double valor)
        {
            Num = num;
            Nome = nome;
            Valor = valor;
        }

        public void Deposito(double dep)
        {
            Valor += dep;
        }
        public void Saque(double saque)
        {
            Valor -= (saque + 5);
        }
        public override string ToString()
        {
            return "Conta " + Num + ", Titular: " + Nome + ", Saldo: $ " + Valor.ToString("F2");
        }
    }
}
