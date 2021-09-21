using System;

namespace Pessoas
{
    class PessoaJuridica : Pessoa
    {

        public string Cnpj { get; set; }

        public PessoaJuridica(string Nome, string Cnpj)
        {
            this.Nome = Nome;
            this.Cnpj = Cnpj;
        }
    }
}
