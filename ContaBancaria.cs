﻿using System.Globalization;
namespace ExBanco
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this (numero, titular)
        {
            Depositar(depositoInicial);
        }


        public void Depositar(double saldo)
        {
            Saldo += saldo;
        }

        public void Sacar(double saldo)
        {
            Saldo -= saldo + 5;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
