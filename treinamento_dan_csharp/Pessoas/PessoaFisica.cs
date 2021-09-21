using System;

namespace Pessoas
{
    class PessoaFisica : Pessoa
    {

        public string Cpf { get; set; }

        public PessoaFisica(string Nome, string Cpf)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
        }
    }
}
