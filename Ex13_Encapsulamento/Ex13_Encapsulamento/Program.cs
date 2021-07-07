using System;
using System.Globalization;

namespace Ex13_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 900.00, 10);
            Console.WriteLine(p.GetNome());
            p.SetNome("TV 4k");
            Console.WriteLine(p.GetNome());
        }
    }
}
