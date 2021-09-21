using classes;
using System;

namespace Banco
{
    class Program
    {

        public static BankAccount account = new("BANK", 1000);

        static void Main()
        {
            WhatToDo();
        }

        static void MakeDeposit()
        {
            Console.WriteLine("How much is the deposit?");
            int deposit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write a comment for the deposit");
            string comment = Console.ReadLine();
            account.MakeDeposit(deposit, DateTime.Now, comment);
            WhatToDo();
        }

        static void MakeWithdrawal()
        {
            Console.WriteLine("How much is the withdrawl?");
            int deposit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write a comment for the withdrawl");
            string comment = Console.ReadLine();
            account.MakeWithdrawal(deposit, DateTime.Now, comment);
            WhatToDo();
        }

        static void WhatToDo()
        {
            Console.WriteLine("What to do?\n" +
                "1- Deposit\n" +
                "2- Withdrawal\n" +
                "3- List history\n" +
                "4- Check balance\n" +
                "5- Leave");
            int sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    MakeDeposit();
                    break;

                case 2:
                    MakeWithdrawal();
                    break;

                case 3:
                    account.GetAccountHistory();
                    Console.WriteLine("");
                    WhatToDo();
                    break;

                case 4:
                    Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} current balance.");
                    Console.WriteLine("");
                    WhatToDo();
                    break;

                case 5:
                    break;

                default:
                    WhatToDo();
                    break;
            }
        }

    }

}
