using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class ProdutoVetor
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public ProdutoVetor(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
