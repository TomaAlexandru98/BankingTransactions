using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingTransactions.Abstractions
{
    public interface IMenu
    {
        Dictionary<int, string> MenuOptions { get; set; }
        int Show()
        {
            var orderedList = MenuOptions.Keys.OrderBy(keys => keys);

            for(int i = 0; i < orderedList.Count(); i++)
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
