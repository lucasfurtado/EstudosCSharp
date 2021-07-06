using System;
using System.Globalization;

namespace Ex08_FinanceiroMembrosEstáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantia, cotacao;

            Console.Write("Qual é a cotação do dólar? ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Converter(quantia, cotacao).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
