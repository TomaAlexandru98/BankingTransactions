using BankingTransactions.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions
{
    public abstract class Card
    {
        private CardData Data = new CardData();
        public int Id { get; set; }
        public string Name { get; set; }
        public void Transfer()
        {
            Data.GetDataFromConsole();
            
            if (CheckDataFromConsole() == true)
            {
                PrintTransactionSucced();
                return;
            }

            PrintTransactionFailed();
        }

        public abstract void PrintTransactionSucced();
        public abstract void PrintTransactionFailed();
        public Boolean CheckDataFromConsole()
        {
            return false;
        }
    }
}
