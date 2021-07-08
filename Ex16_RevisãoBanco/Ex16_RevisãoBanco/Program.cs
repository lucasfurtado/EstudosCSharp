using System;
using System.Globalization;

namespace Ex16_RevisãoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb;

            int numero;
            string nome;
            double valor;
            char opcao;

            Console.Write("Entre o número da conta: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            opcao = char.Parse(Console.ReadLine());

            if(opcao == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                cb = new ContaBancaria(numero, nome, valor);

            }
            else
            {
                cb = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(cb);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Depositar(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Sacar(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);
        }
    }
}
