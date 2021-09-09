using System;

namespace Ex25_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha, coluna, numAnalise;
            string resposta="";
            int[,] matriz;

            string atributoMatriz = Console.ReadLine();
            string[] atributoMatrizVect = atributoMatriz.Split(" ");

            linha = int.Parse(atributoMatrizVect[0]);
            coluna = int.Parse(atributoMatrizVect[1]);
            matriz = new int[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                string[] linhaAux = Console.ReadLine().Split(" ");
                for (int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = int.Parse(linhaAux[j]);
                }
            }

            numAnalise = int.Parse(Console.ReadLine());

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (matriz[i, j] == numAnalise)
                    {
                        resposta += string.Concat("Position ", i, ",", j, "\r\n");

                        if (i > 0) resposta += string.Concat("Up: ", matriz[i-1,j], "\r\n");
                        if (j > 0) resposta += string.Concat("Left: ", matriz[i, j-1], "\r\n");
                        if (j < coluna - 1) resposta += string.Concat("Right: ", matriz[i, j+1], "\r\n");
                        if (i < linha - 1) resposta += string.Concat("Down: ", matriz[i+1,j], "\r\n");
                    }
                }
            }
            Console.WriteLine(resposta);
        }
    }
}
