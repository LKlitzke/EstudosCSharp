using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class ProdutoEX12
    {
        private string _nome;
        private double _preco;
        private double _qtd;


        public ProdutoEX12(string nome, double preco, double qtd)
        {
            _nome = nome;
            _preco = preco;
            _qtd = qtd;
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
        public double Preco
        {
            get { return _preco; }
        }
        public double Quant
        {
            get { return _qtd; }
        }

        public void AdicionarProdutos(double qtd)
        {
            _qtd += qtd;
        }

        public void RemoverProdutos(double qtd)
        {
            _qtd -= qtd;
        }
        public override string ToString()
        {
            return "Dados do produto: " + _nome + ", R$ " + _preco.ToString("F2") + ", " + _qtd + " unidades, Total = " + (_preco * _qtd).ToString("F2");
        }
    }
}
