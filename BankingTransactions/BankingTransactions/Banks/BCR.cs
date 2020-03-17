using BankingTransactions.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Banks
{
    public class BCR : Bank
    {
        public override void ShowMessage()
        {
            Console.WriteLine("BCR : Transaction succed");
        }
    }
}
