using System;

namespace Ex22_ParamsRefeOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            Calculator.Triple2(a, out b);
            Console.WriteLine(b);
        }
    }
}
