using BankingTransactions.Abstractions;
using BankingTransactions.Menu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingTransactions
{
    
    class MenuBanks : BaseMenu, IMenuBanks
    {
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

        public override void ExecuteMenu()
        {
            //throw new NotImplementedException();
            int option = Show();

            SelectBankForTransfer(option);
        }
    }
}
