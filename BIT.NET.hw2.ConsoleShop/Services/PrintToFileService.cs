using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BIT.NET.hw5.ConsoleShop.Services
{
    public class PrintToFileService : IPrintService
    {
        private string _path = @"C:\Temp\output.txt";

        public void StartMessage()
        {
            File.WriteAllText(_path, "Welcome to the Shop!" + Environment.NewLine);
        }

        public void PrintMenu()
        {
            File.AppendAllText(_path, "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Menu ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + Environment.NewLine);
            File.AppendAllText(_path, "List                  -- Shop Items List" + Environment.NewLine);
            File.AppendAllText(_path, "Buy /item/ /quantity/ -- for eg.: | Buy Candy 20 |" + Environment.NewLine);
            File.AppendAllText(_path, "Add /item/ /quantity/ -- for eg.: | Add Candy 20 |" + Environment.NewLine);
            File.AppendAllText(_path, "Balance               -- User account balance" + Environment.NewLine);
            File.AppendAllText(_path, "Topup /amount/        -- Topup User account balance for eg.: |Topup 15.6|" + Environment.NewLine);
            File.AppendAllText(_path, "Exit                  -- Exit application" + Environment.NewLine);
            File.AppendAllText(_path, "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + Environment.NewLine);
        }

        public void ItemListTitle()
        {
            File.AppendAllText(_path, "_____________________________Items List___________________________________" + Environment.NewLine);
        }

        public void ItemList(string name, double price, int quantity)
        {
            File.AppendAllText(_path, $"{name}, price: {price} EUR, quantity: {quantity} pcs." + Environment.NewLine);
        }

        public void BuyPrint(string operationResult, int quantity, string itemBought)
        {
            if (operationResult == "")
            {
                File.AppendAllText(_path, $"----------You just bought {quantity} {itemBought}----------" + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(_path, operationResult + Environment.NewLine);
            }
        }
        public void AddPrint(string itemAdded, int quantity)
        {
            File.AppendAllText(_path, $"----------You just added {quantity} {itemAdded} to the Shop----------" + Environment.NewLine);
        }

        public void BalancePrint(double balance)
        {
            File.AppendAllText(_path, $"Your card balance: {balance} EUR" + Environment.NewLine);
        }
    }
}

