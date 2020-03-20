using BankingTransactions.Abstractions;
using BankingTransactions.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingTransactions
{
    class MenuApp : BaseMenu
    {
        private readonly IMenuBanks menuBanks;
        private readonly IMenuCards menuCards;
        public MenuApp(IMenuBanks menuBanks, IMenuCards menuCards)
        {
            this.menuBanks = menuBanks;
            this.menuCards = menuCards;
        }

        public override void ExecuteMenu()
        {
            var option = this.Show();

            switch (option)
            {
                case 1:
                    {
                        BankTransfer();
                        break;
                    }
                case 2:
                    {
                        CardTransfer();
                        break;
                    }

            }
        }

        private void CardTransfer()
        {
            Console.WriteLine("\nWelcome to payment by card");

            menuCards?.ExecuteMenu();
        }

        private void BankTransfer()
        {
            Console.WriteLine("\nWelcome to payment by bank transfer");

            menuBanks?.ExecuteMenu();
        }
    }
}
