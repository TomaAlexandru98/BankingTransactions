using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Abstractions
{
    public interface IMenuBanks : IMenu
    {
        void SelectBankForTransfer(int id);
        void AddBank(Bank bank);
    }
}
