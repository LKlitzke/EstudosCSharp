using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class FuncionarioEX7
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double pct)
        {
            SalarioBruto += pct / 100 * SalarioBruto;
        }

        public override string ToString()
        {
            return "Funcionário: " + Nome + ", $ " + SalarioLiquido().ToString("F2");
        }
    }
}
