using System;

namespace Pessoasvd
{
    class PessoaJuridica : Pessoa
    {
        public int Cnpj { get; set; }

        public PessoaJuridica (string nome, int Cnpj){
            this.Nome = Nome;
            this.Cnpj = Cnpj;
        }
    }
}