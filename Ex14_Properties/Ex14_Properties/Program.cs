using System;

namespace Ex14_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 900.00, 10);

            Console.WriteLine(p.Nome);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);

        }
    }
}
