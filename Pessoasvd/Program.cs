using System;
using System.Collections.Generic;

namespace Pessoasvd
{
    class Program
    {

        public static List<PessoaFisica> todasFisicas = new();
        public static List<PessoaJuridica> todasJuridicas = new();
        private static int sw = 0;

        static void Main()
        {
            OQueDesejaFazer();
        }

        static void NovaPessoaFisica()
        {
            Console.WriteLine("Qual o nome da pessoa física que deseja registrar?\n");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o cpf da pessoa física?\n");
            int Cpf = Convert.ToInt32(Console.ReadLine());
            var pFisica = new PessoaFisica(nome, Cpf);
            todasFisicas.Add(pFisica);
            OQueDesejaFazer();
        }

        static void NovaPessoaJuridica()
        {
            Console.WriteLine("Qual o nome da pessoa juridica que deseja registrar?\n");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o cnpj da pessoa juridica?\n");
            int Cnpj = Convert.ToInt32(Console.ReadLine());
            var pJuridica = new PessoaJuridica(nome, Cnpj);
            todasJuridicas.Add(pJuridica);
            OQueDesejaFazer();
        }

        static void ListarPessoaFisica()
        {
            foreach (var item in todasFisicas)
            {
                Console.WriteLine($"{item.Nome}\t\t{item.Cpf}\n");
            }
            Console.WriteLine("\n");
            OQueDesejaFazer();
        }

        static void ListarPessoaJuridica()
        {
            foreach (var item in todasJuridicas)
            {
                Console.WriteLine($"{item.Nome}\t\t{item.Cnpj}\n");
            }
            OQueDesejaFazer();
        }

        static void OQueDesejaFazer()
        {
            Console.WriteLine("O que deseja fazer?\n" +
                "1- Adicionar nova pessoa fisica\n" +
                "2- Adicionar nova pessoa juridica\n" +
                "3- Listar todas as pessoas fisicas\n" +
                "4- Listar todas as pessoas juridicas");
            int sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    NovaPessoaJuridica();
                    break;

                case 2:
                    NovaPessoaFisica();
                    break;

                case 3:
                    ListarPessoaJuridica();
                    break;

                case 4:
                    ListarPessoaFisica();
                    break;

                default:
                    OQueDesejaFazer();
                    break;
            }
        }


    }

}