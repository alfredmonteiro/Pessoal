using System;
using System.Globalization;

namespace Conta_Bancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            double saque = quantia + 5;
            if (Saldo - saque >= 0)
            {
                Saldo -= saque;
                System.Console.WriteLine("Saque realizado com sucesso!");
                System.Console.WriteLine();
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente!");
                System.Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);        
        }

    }
}
