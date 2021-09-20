using System;

namespace Pessoas
{
    class PessoaJuridica : Pessoa
    {
        public int cnpj { get; set; }

        public PessoaJuridica (string nome, int cnpj){
            this.nome = nome;
            this.cnpj = cnpj;
        }
    }
}