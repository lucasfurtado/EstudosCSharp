using System;
using System.Collections.Generic;
using System.Text;

namespace Ex22_ParamsRefeOut
{
    class Calculator
    {
        public static int Triple(ref int x)
        {
            return x = x * 3;
        }

        public static void Triple2(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
