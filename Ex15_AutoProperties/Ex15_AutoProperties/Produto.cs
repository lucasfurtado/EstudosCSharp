using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex15_AutoProperties
{
    class Produto
    {
        private string _nome;
        public double Preco { get; set; }
        public int Quantidade { get; private set; }

        public string Nome
        {
            get { return _nome; }

            set
            {
                if (value != null && value.Length > 1) _nome = value;
            }
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return _nome + ", $ " +
                Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " +
                Quantidade +
                " unidades, Total: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
