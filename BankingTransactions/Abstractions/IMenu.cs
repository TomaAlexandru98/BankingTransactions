using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingTransactions.Abstractions
{
    public interface IMenu
    {
        int Show();

        void ExecuteMenu();
    }
}
