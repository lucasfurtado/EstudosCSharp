using System;

namespace _NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int cont = 0;

            Console.WriteLine("É primo?");
            Console.Write("Digite um número: ");

            numero = int.Parse(Console.ReadLine());

            for (int i = numero; i >= 1; i--)
            {
                if(numero % i == 0)
                {
                    cont++;
                }
            }

            if(cont == 2 || numero == 1)
            {
                Console.WriteLine("É PRIMO");
            }
            else
            {
                Console.WriteLine("NÃO É PRIMO");
            }
        }

    }
}
