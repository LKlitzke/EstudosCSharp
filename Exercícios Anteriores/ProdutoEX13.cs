using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class ProdutoEX13
    {
        private string _nome;
        public double Preco { get; private set; }
        public double Qtd { get; private set; }


        public ProdutoEX13(string nome, double preco, double qtd)
        {
            _nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 3)
                {
                    _nome = value;
                }
            }
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
            return "Dados do produto: " + _nome + ", R$ " + Preco.ToString("F2") + ", " + Qtd + " unidades, Total = " + (Preco * Qtd).ToString("F2");
        }
    }
}
