using BankingTransactions.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Banks
{
    public class BancaTransilvania : Bank
    {
        public override void PrintTransactionFailed()
        {
            Console.WriteLine("BancaTransilvania : Transaction Succed");
        }

        public override void PrintTransactionSucced()
        {
            Console.WriteLine("BancaTransilvania : Transaction failed");
        }
    }
}
