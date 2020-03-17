using BankingTransactions.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Banks
{
    public class BRD : Bank
    {
        public override void ShowMessage()
        {
            Console.WriteLine("BRD : Transaction succed");
        }
    }
}
