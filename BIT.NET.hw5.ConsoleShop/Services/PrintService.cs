using System;
using System.Collections.Generic;
using System.Text;

namespace BIT.NET.hw5.ConsoleShop.Services
{
    public class PrintService: IPrintService
    {
        public void StartMessage()
        {
            Console.WriteLine("Welcome to the Shop!");
        }

        public void PrintMenu()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Menu ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("List                  -- Shop Items List");
            Console.WriteLine("Buy /item/ /quantity/ -- for eg.: | Buy Candy 20 |");
            Console.WriteLine("Add /item/ /quantity/ -- for eg.: | Add Candy 20 |");
            Console.WriteLine("Balance               -- User account balance");
            Console.WriteLine("Topup /amount/        -- Topup User account balance for eg.: |Topup 15.6|");
            Console.WriteLine("Exit                  -- Exit application");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        public void ItemListTitle()
        {
            Console.WriteLine("_____________________________Items List___________________________________");
        }

        public void ItemList(string name, double price, int quantity)
        {
            Console.WriteLine($"{name}, price: {price} EUR, quantity: {quantity} pcs.");
        }

        public void BuyPrint(string operationResult, int quantity, string itemBought)
        {
            if (operationResult == "")
            {
                Console.WriteLine($"----------You just bought {quantity} {itemBought}----------");
            }
            else
            {
                Console.WriteLine(operationResult);
            }
        }
        public void AddPrint(string itemAdded, int quantity)
        {
            Console.WriteLine($"----------You just added {quantity} {itemAdded} to the Shop----------");
        }

        public void BalancePrint(double balance)
        {
            Console.WriteLine($"Your card balance: {balance} EUR");
        }
    }
}
