using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Quarto(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
