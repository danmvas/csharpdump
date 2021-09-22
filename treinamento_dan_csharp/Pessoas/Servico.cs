using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas
{
    class servico
    {

        public static List<PessoaFisica> todasFisicas = new();
        public static List<PessoaJuridica> todasJuridicas = new();


        static public void NovaPessoaFisica()
        {
            Console.WriteLine("");
            Console.WriteLine("Qual o Nome da pessoa física que deseja registrar?");
            string Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Qual o cpf da pessoa física?");
            string cpf = Console.ReadLine();
            var pFisica = new PessoaFisica(Nome, cpf);
            todasFisicas.Add(pFisica);
            Console.WriteLine("");
            OQueDesejaFazer();
        }

        static public void NovaPessoaJuridica()
        {
            Console.WriteLine("");
            Console.WriteLine("Qual o Nome da pessoa juridica que deseja registrar?");
            string Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Qual o cnpj da pessoa juridica?");
            string cnpj = Console.ReadLine();
            var pJuridica = new PessoaJuridica(Nome, cnpj);
            todasJuridicas.Add(pJuridica);
            Console.WriteLine("");
            OQueDesejaFazer();
        }

        static public void ListarPessoaFisica()
        {
            Console.WriteLine("");
            foreach (var item in todasFisicas)
            {
                Console.WriteLine($"{item.Nome}\t{item.Cpf}");
            }
            Console.WriteLine("");
            OQueDesejaFazer();
        }

        static public void ListarPessoaJuridica()
        {
            Console.WriteLine("");
            foreach (var item in todasJuridicas)
            {
                Console.WriteLine($"{item.Nome}\t\t{item.Cnpj}");
            }
            Console.WriteLine("");
            OQueDesejaFazer();
        }

        static public void OQueDesejaFazer()
        {
            Console.WriteLine("O que deseja fazer?\n" +
                "1- Adicionar nova pessoa fisica\n" +
                "2- Adicionar nova pessoa juridica\n" +
                "3- Listar todas as pessoas fisicas\n" +
                "4- Listar todas as pessoas juridicas\n" +
                "5- Sair");
            int sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    NovaPessoaFisica();
                    break;

                case 2:
                    NovaPessoaJuridica();
                    break;

                case 3:
                    ListarPessoaFisica();
                    break;

                case 4:
                    ListarPessoaJuridica();
                    break;

                case 5:
                    break;

                default:
                    OQueDesejaFazer();
                    break;
            }
        }



    }
}
