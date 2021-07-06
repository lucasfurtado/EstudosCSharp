using System;
using System.Globalization;

namespace Ex11_SintaxeAlternativaConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p;

            string nome;
            double preco;
            int qtd;

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = new Produto
            {
                Nome = nome,
                Preco = preco,
                Quantidade = qtd,
            };

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            Console.WriteLine("Dados do produto: " + p);
        }
    }
}
