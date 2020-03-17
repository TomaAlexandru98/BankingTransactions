using BankingTransactions.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Banks
{
    public class BancaTransilvania : Bank
    {
        public override void ShowMessage()
        {
            Console.WriteLine("Banca Transilvania : Transaction succed");
        }
    }
}
