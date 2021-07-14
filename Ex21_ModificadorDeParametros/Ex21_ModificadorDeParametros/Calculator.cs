using System;
using System.Collections.Generic;
using System.Text;

namespace Ex21_ModificadorDeParametros
{
    class Calculator
    {
        public static int Sum(params int[] number)
        {
            int aux = 0;
            for (int i = 0; i < number.Length; i++) aux += number[i];
            return aux;
        }
    }
}
