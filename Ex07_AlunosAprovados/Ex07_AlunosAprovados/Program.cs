using System;
using System.Globalization;

namespace Ex07_AlunosAprovados
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos a = new Alunos();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Prova1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Prova2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Prova3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal());

            if(a.NotaFinal() >= 60.0)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60-a.NotaFinal()) + " PONTOS");
            }
        }
    }
}
