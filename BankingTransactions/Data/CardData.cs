using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Data
{
    public class CardData
    {
        private int Number;
        private int CVV;

        public void GetDataFromConsole()
        {
            Console.WriteLine("Enter number of card : ");
            string numberStr = Console.ReadLine();
            Number = int.Parse(numberStr);

            Console.WriteLine("Enter CVV : ");
            string cvvStr = Console.ReadLine();
            CVV = int.Parse(cvvStr);
        }
    }
}
