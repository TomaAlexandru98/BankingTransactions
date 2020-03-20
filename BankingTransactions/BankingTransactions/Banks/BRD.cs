using BankingTransactions.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Banks
{
    public class BRD : Bank
    {
        public override void PrintTransactionFailed()
        {
            Console.WriteLine("BRD : Transaction Succed");
        }

        public override void PrintTransactionSucced()
        {
            Console.WriteLine("BRD : Transaction failed");
        }
    }
}
