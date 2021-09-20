using System;

namespace Pessoas
{
    class Program
    {

        static void Main(string[] args)
        {
            
            public List<PessoaFisica> todasFisicas = new List<PessoaFisica>();
            public List<PessoaJuridica> todasJuridicas = new List<PessoaJuridica>();
            Console.WriteLine("O que deseja fazer?");
            int sw = Console.ReadLine();
            OQueDesejaFazer();
        }

        void OQueDesejaFazer(){
            switch (sw)
            {
                case 1:
                    NovaPessoaJuridica();
                
                case 2:
                    NovaPessoaFisica();
                
                case 3:
                    ListarPessoaJuridica();
                
                case 4:
                    NovaPessoaFisica();

                default:
                    OQueDesejaFazer();
            }
        }

        void NovaPessoaFisica(){
            Console.WriteLine("Qual o nome da pessoa física que deseja registrar?\n");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o cpf da pessoa física?\n");
            int cpf = Console.ReadLine();
            var pFisica = new PessoaFisica(nome, cpf);
            todasJuridicas.Add(pFisica);
            OQueDesejaFazer();
        }

        void NovaPessoaJuridica(){
            Console.WriteLine("Qual o nome da pessoa juridica que deseja registrar?\n");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o cnpj da pessoa juridica?\n");
            int cnpj = Console.ReadLine();
            var pJuridica = new PessoaFisica(nome, cnpj);
            todasJuridicas.Add(pJuridica);
            OQueDesejaFazer();
        }  

        void ListarPessoaFisica(){
            foreach (var item in todasFisicas)
            {
                Console.WriteLine($"{item.nome}\t\t{item.cpf}\n");
            }
            Console.WriteLine("\n");
            OQueDesejaFazer();
        }

        void ListarPessoaJuridica(){
            foreach (var item in todasJuridicas)
            {
                Console.WriteLine($"{item.nome}\t\t{item.cnpj}\n");
            }
            OQueDesejaFazer();
        }

    }
}
