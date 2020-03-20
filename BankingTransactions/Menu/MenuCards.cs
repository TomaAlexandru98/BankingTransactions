using BankingTransactions.Abstractions;
using BankingTransactions.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions
{
    public class MenuCards : BaseMenu, IMenuCards
    {
        private readonly IList<Card> CardsList = new List<Card>(); 
        
        public void SelectCardForTransfer(int id)
        {
            foreach (var card in CardsList)
            {
                if (card.Id == id)
                {
                    card.Transfer();
                    return;
                }
            }
        }

        public void AddCard(Card card)
        {
            CardsList.Add(card);
            MenuOptions.Add(card.Id, card.Name);
        }

        public override void ExecuteMenu()
        {
            int option = Show();
            SelectCardForTransfer(option);
        }
    }
}
