using BankingTransactions.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingTransactions
{
    
    class MenuBanks : IMenuBanks
    {
        public Dictionary<int, string> MenuOptions { get; set; }
        private readonly IList<Bank> BanksList = new List<Bank>();

        public void SelectBankForTransfer(int id)
        {
            foreach(var bank in BanksList)
            {
                if(bank.Id == id)
                {
                    bank.Transfer();
                    return;
                }
            }
        }
        
        public void AddBank(Bank bank)
        {
            BanksList.Add(bank);
            MenuOptions.Add(bank.Id, bank.Name);
        }
    }
}
