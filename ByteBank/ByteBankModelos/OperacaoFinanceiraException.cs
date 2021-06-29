
using System;


namespace ByteBank.ByteBankModelos
{
    public class OperacaoFinanceiraException : Exception
    {

        public OperacaoFinanceiraException() { } // construtor sem argumentos

        public OperacaoFinanceiraException(string mensagem)
        : base(mensagem) { } // construtor com mensagem

        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna)
        : base(mensagem, excecaoInterna) { } // construtor com mensagem e InnerException
    }
}