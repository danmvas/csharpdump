using System;

namespace Pessoas
{
    class PessoaFisica : Pessoa
    {
        public int Cpf { get; set; }

        public PessoaFisica (string nome, int cpf){
            this.nome = nome;
            this.cpf = cpf;
        }
    }
}
