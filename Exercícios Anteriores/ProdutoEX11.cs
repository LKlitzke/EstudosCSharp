using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class ProdutoEX11
    {
        private string _nome;
        private double _preco;
        private double _qtd;


        public ProdutoEX11(string nome, double preco, double qtd)
        {
            _nome = nome;
            _preco = preco;
            _qtd = qtd;
        }

        public string getNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if(_nome != null && nome.Length > 3)
            {
                _nome = nome;
            }
                
        }
        public double getPreco()
        {
            return _preco;
        }
        public double getQuant()
        {
            return _qtd;
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
