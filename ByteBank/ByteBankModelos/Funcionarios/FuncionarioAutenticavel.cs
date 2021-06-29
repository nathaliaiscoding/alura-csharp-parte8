using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.ByteBankModelos.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        // código omitido
        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhar(Senha, senha);
        }

        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {
        }
    }

}
