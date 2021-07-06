using System;
using System.Collections.Generic;
using System.Text;

namespace Ex07_AlunosAprovados
{
    class Alunos
    {
        public string Nome;
        public double Prova1, Prova2, Prova3;

        public double NotaFinal()
        {
            return Prova1 + Prova2 + Prova3;
        }

    }
}
