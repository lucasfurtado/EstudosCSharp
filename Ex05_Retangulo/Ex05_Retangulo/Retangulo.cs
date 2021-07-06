using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05_Retangulo
{
    class Retangulo
    {
        public double Largura, Altura;

        public double CalculaArea()
        {
            return Largura * Altura;
        }

        public double CalculaPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double CalculaDiagonal()
        {
            return Math.Sqrt( Math.Pow(Largura,2) + Math.Pow(Altura,2) );
        }
    }
}
