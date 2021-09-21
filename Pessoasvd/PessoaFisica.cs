using System;

namespace Pessoasvd
{
    class PessoaFisica : Pessoa
    {
        public int Cpf { get; set; }

        public PessoaFisica (string nome, int Cpf){
            this.Nome = Nome;
            this.Cpf = Cpf;
        }
    }
}
