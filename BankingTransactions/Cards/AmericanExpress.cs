using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Cards
{
    public class AmericanExpress : Card
    {
        public override void PrintTransactionFailed()
        {
            Console.WriteLine("American Express : Transaction failed ");
        }

        public override void PrintTransactionSucced()
        {
            Console.WriteLine("American Express : Transaction succed ");
        }
    }
}
