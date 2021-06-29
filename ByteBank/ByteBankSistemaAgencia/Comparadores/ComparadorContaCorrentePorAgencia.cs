using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.ByteBankModelos;

namespace ByteBank.ByteBankSistemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }
            if (x.Agencia < y.Agencia)
            {
                return -1; // X fica na frente de Y
            }

            if (x.Agencia == y.Agencia)
            {
                return 0; // São equivalentes
            }

            return 1;

            // uma vez que o tipo int implementa a interface IComparer,
            // poderíamos substituir a lógica acima pela chamada 
            // return x.Agencia.CompareTo(y.Agencia);
        }
    }
}
