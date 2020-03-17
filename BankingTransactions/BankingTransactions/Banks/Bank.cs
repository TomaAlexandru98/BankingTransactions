using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Abstractions
{
    public abstract class Bank
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Transfer()
        {
            Console.WriteLine("Enter your name :");
            Console.ReadLine();

            Console.WriteLine("Enter your IBAN :");
            Console.ReadLine();

            Console.WriteLine("Enter the amount of money :");
            Console.ReadLine();

            ShowMessage();
        }

        public abstract void ShowMessage();
        
    }
}
