using System;
using System.Globalization;

namespace Ex17_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            double cont = 0;

            int tamanho = int.Parse(Console.ReadLine());

            double[] vect = new double[tamanho];

            for(int i = 0; i < tamanho; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cont += vect[i];
            }

            Console.WriteLine("AVARAGE HEIGHT = " + (cont/tamanho).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
