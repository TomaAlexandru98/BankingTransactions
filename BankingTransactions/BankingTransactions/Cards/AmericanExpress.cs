﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Cards
{
    public class AmericanExpress : Card
    {
        public override void ShowMessage()
        {
            Console.WriteLine("Transaction succed with card American Express");
        }
    }
}