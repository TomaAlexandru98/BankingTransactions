using BankingTransactions.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Banks
{
    public class BCR : Bank
    {
        public override void PrintTransactionFailed()
        {
            Console.WriteLine("BCR : Transaction Succed");
        }

        public override void PrintTransactionSucced()
        {
            Console.WriteLine("BCR : Transaction failed");
        }
    }
}
