using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions
{
    class BankData
    {
        private int IBAN;
        private int AmountOfMoney;
        
        public void GetDataFromConsole()
        {
            Console.WriteLine("Enter IBAN :");
            string iBANStr = Console.ReadLine();
            IBAN = int.Parse(iBANStr);

            Console.WriteLine("Enter amount of money : ");
            string amountOfMoneyStr = Console.ReadLine();
            AmountOfMoney = int.Parse(amountOfMoneyStr);
        }
    }
}
