using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Cards
{
    public class Visa : Card
    {
        public override void PrintTransactionFailed()
        {
            Console.WriteLine("Visa : Transaction failed ");
        }

        public override void PrintTransactionSucced()
        {
            Console.WriteLine("Visa : Transaction succed ");
        }
    }
}
