using System;
using System.Globalization;

namespace Ex18_VetorDeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            double aux = 0;

            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product(nome, preco);

                aux += vect[i].Preco;
            }

            Console.WriteLine("AVAREGE PRICE = " + (aux/n).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
