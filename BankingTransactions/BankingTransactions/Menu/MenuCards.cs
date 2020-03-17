using BankingTransactions.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTransactions
{
    public class MenuCards : IMenuCards
    {
        public Dictionary<int, string> MenuOptions { get; set; }
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
    }
}
