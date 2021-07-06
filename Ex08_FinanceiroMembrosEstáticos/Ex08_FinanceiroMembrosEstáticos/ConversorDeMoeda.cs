using System;
using System.Collections.Generic;
using System.Text;

namespace Ex08_FinanceiroMembrosEstáticos
{
    public static class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double Converter(double quantia, double cotacao)
        {
            double ComCotação = quantia * cotacao;
            return ComCotação * Iof / 100 + ComCotação;
        }
    }
}
