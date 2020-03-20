using BankingTransactions.Abstractions;
using BankingTransactions.Banks;
using BankingTransactions.Cards;
using System;
using System.Collections.Generic;

namespace BankingTransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("******************************************Welcome to banking transactions***********************************************");

            IMenuBanks banksMenu = CreateBanksMenu();
            IMenuCards cardsMenu = CreateCardsMenu();

            IMenu menu = new MenuApp(banksMenu, cardsMenu)
            {
                MenuOptions = new Dictionary<int, string>()
                {
                    { 1, "Payment by bank transfer" },
                    { 2, "Payment by card" }
                }
            };

            menu.ExecuteMenu();

          
        }

        private static IMenuCards CreateCardsMenu()
        {
            

            IMenuCards menu = new MenuCards()
            {
                MenuOptions = new Dictionary<int, string>()
            };

            {
                menu.AddCard(new Visa()
                {
                    Id = 1,
                    Name = "Visa"
                }
                    );

                menu.AddCard(new MasterCard()
                {
                    Id = 2,
                    Name = "MasterCard"
                }
                    );

                menu.AddCard(new AmericanExpress()
                {
                    Id = 3,
                    Name = "AmericanExpress"
                }
                    );
            }
            return menu;
        }

        private static IMenuBanks CreateBanksMenu()
        {

            IMenuBanks menu = new MenuBanks()
            {
                MenuOptions = new Dictionary<int, string>()            
            };
            
            {
                menu.AddBank(new BCR()
                {
                    Id = 1,
                    Name = "BCR"
                }
                    );
                menu.AddBank(new BRD()
                {
                    Id = 2,
                    Name = "BRD"
                }
                    );
                menu.AddBank(new BancaTransilvania()
                {
                    Id = 3,
                    Name = "Banca Transilvania"
                }
                    );
            }

            return menu;
        }
    }
}
