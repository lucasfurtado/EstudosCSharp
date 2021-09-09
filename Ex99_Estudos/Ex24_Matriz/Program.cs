using System;

namespace Ex24_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            String[] vectAux; 

            for (int i = 0; i < n; i++)
            {
                vectAux = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(vectAux[j]);
                }
            }

            Console.WriteLine("Main Diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(string.Concat(matrix[i,i], " "));
            }
            Console.WriteLine();

            int totalNegative = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 0) totalNegative++;
                }
            }

            Console.WriteLine(string.Concat("Negative numbers = ",totalNegative));
        }
    }
}
