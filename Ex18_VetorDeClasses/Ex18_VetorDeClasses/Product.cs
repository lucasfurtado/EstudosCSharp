using System;
using System.Collections.Generic;
using System.Text;

namespace Ex18_VetorDeClasses
{
    class Product
    {
        public string Nome { set; get; }
        public double Preco { set; get; }

        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
