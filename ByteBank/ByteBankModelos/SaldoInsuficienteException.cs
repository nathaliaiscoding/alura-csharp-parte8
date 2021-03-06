using System;


namespace ByteBank.ByteBankModelos
{
    public class SaldoInsuficienteException : Exception
    {

        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException()
        {
        }
        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque de " + valorSaque + " com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {
        }
    }
}