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

            IMenu menu = new MenuApp()
            {
                MenuOptions = new Dictionary<int, string>()
                {
                    { 1, "Payment by bank transfer" },
                    { 2, "Payment by card" }
                }
            };

            var option = menu.Show();

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

        private static void CardTransfer()
        {
            Console.WriteLine("\nWelcome to payment by card");

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

            int option = menu.Show();
            menu.SelectCardForTransfer(option);

        }

        private static void BankTransfer()
        {
            Console.WriteLine("\nWelcome to payment by bank transfer");

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
            
            int option = menu.Show();
            menu.SelectBankForTransfer(option);
        }
    }
}
