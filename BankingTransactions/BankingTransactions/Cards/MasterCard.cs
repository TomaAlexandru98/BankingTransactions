﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Cards
{
    public class MasterCard : Card
    {
        public override void ShowMessage()
        {
            Console.WriteLine("Transaction succed with card MasterCard");
        }
    }
}
