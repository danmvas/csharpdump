using System;

namespace Pessoas
{
    abstract class Pessoa
    {
        public string Nome { get; set; }

        public string NomeMaisculo
        {
            get => Nome[0].ToString().ToUpper() + Nome.ToLower()[1..Nome.Length];
        }
    }
}