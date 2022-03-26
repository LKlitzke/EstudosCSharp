using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class ProdutoEX10
    {
        public string Nome;
        public double Preco;
        public double Qtd;


        public ProdutoEX10(string nome, double preco, double qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public void AdicionarProdutos(double qtd)
        {
            Qtd += qtd;
        }

        public void RemoverProdutos(double qtd)
        {
            Qtd -= qtd;
        }
        public override string ToString()
        {
            return "Dados do produto: " + Nome + ", R$ " + Preco.ToString("F2") + ", " + Qtd + " unidades, Total = " + (Preco*Qtd).ToString("F2");
        }
    }
}
