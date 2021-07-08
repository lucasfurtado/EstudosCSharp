using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex16_RevisãoBanco
{
    class ContaBancaria
    {
        //declarações de atributos propriedades autoimplementadas
        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        //construtores
        public ContaBancaria(int numero, string titular)
        {
            NumeroConta = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        //Métodos
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5.0; //há uma taxa de 5 reais para todos os saques
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", " +
                "Titular: " + Titular + ", " +
                "Saldo: " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
