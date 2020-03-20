using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Cards
{
    public class MasterCard : Card
    {
        public override void PrintTransactionFailed()
        {
            Console.WriteLine("MasterCard : Transaction failed ");
        }

        public override void PrintTransactionSucced()
        {
            Console.WriteLine("MasterCard: Transaction succed ");
        }
    }
}
