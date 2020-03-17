using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions
{
    public abstract class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Transfer()
        {
            Console.WriteLine("Enter pin :");
            Console.ReadLine();

            Console.WriteLine("Enter the amount of money :");
            Console.ReadLine();

            ShowMessage();
        }

        public abstract void ShowMessage();
    }
}
