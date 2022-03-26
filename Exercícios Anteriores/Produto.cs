using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd;
        }
        public void RemoverProdutos(int qtd)
        {
            Quantidade -= qtd;
        }
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
