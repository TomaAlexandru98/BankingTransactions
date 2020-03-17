using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions.Abstractions
{
    public interface IMenuCards : IMenu
    {
        void SelectCardForTransfer(int id);
        void AddCard(Card card);
    }
}
