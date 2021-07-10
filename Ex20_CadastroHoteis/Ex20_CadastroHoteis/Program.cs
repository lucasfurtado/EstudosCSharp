using System;

namespace Ex20_CadastroHoteis
{
    class Program
    {
        static void Main(string[] args)
        {

            Quarto[] vect = new Quarto[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numero = int.Parse(Console.ReadLine());

                vect[numero] = new Quarto(nome, email, numero);

                Console.WriteLine();
            }

            for(int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
        }
    }
}
