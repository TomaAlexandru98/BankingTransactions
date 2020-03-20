using BankingTransactions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingTransactions.Menu
{
    public abstract class BaseMenu : IMenu
    {
        public Dictionary<int, string> MenuOptions { get; set; }

        public abstract void ExecuteMenu();

        public int Show()
        {
            var orderedList = MenuOptions.Keys.OrderBy(keys => keys);

            for (int i = 0; i < orderedList.Count(); i++)
            {
                Console.WriteLine($"{orderedList.ElementAt(i)}. {MenuOptions[orderedList.ElementAt(i)]}");
            }

            Console.WriteLine("\nPlease choose an option :");

            var optionStr = Console.ReadLine();
            int option;
            int.TryParse(optionStr, out option);

            return option;
        }


    }
}
