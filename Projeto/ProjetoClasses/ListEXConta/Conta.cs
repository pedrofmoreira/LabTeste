/*

using System;
using System.Collections.Generic;
using System.Text;

namespace ListEXConta
{
    class Conta
    {
        public double Vdeposito;
        public String Nome;
        public int Nconta;
        public double Saldo;
        public double Taxa = 5.00;
        public double Saque;
        public bool Dinicial;

        public void AdicionarDeposito(double vdeposito)
        {
            Vdeposito += vdeposito;
        }

        public void RetiradaSaque(double saque)
        {
            Saque -= saque;
        }

        public void SaldoRestante(double saldo)
        {
            Saldo -= saldo;
        }
    }
    
    
}
*/
using System.Globalization;

namespace ListEXConta
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
            Saldo -= quantia;
            Saldo -= 5.00;
        }



        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}