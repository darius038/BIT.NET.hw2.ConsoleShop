using BIT.NET.hw2.ConsoleShop.Data;
using BIT.NET.hw2.ConsoleShop.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIT.NET.hw2.ConsoleShop.View
{
    public class Shop
    {
        private bool _isStarted = false;
        private List<Item> _shopList;
        private User _user;

        public Shop()
        {
            if (_isStarted)
            {
                throw new Exception("Application already started");
            }
            _isStarted = true;
            _shopList = ShopRepository.ShopList;
            _user = new User();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the Shop!");
            string[] option;
            do
            {                
                option = MainMenu();
                switch (option[0])
                {
                    case "list":
                        ViewList();
                        break;
                    case "buy":
                        Buy(option[1], int.Parse(option[2]));
                        break;
                    case "add":
                        Add(option[1], int.Parse(option[2]));  
                        break;
                    case "balance":
                        Console.WriteLine($"Your card balance: { _user.Balance} EUR");
                        break;
                    case "topup":
                        ShopRepository.TopupUserBalance(_user, double.Parse(option[1]));
                        break;
                }

            } while (option[0] != "exit");
        }

        private string[] MainMenu()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Menu ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("List                  -- Shop Items List");
            Console.WriteLine("Buy /item/ /quantity/ -- for eg.: | Buy Candy 20 |");
            Console.WriteLine("Add /item/ /quantity/ -- for eg.: | Add Candy 20 |");
            Console.WriteLine("Balance               -- User account balance");
            Console.WriteLine("Topup /amount/        -- Topup User account balance for eg.: |Topup 15.6|");
            Console.WriteLine("Exit                  -- Exit application");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string[] menuOption = Console.ReadLine().ToLower().Split(" ");
            return menuOption;
        }

        private void ViewList()
        {
            Console.WriteLine("_____________________________Items List___________________________________");
            foreach (var item in _shopList)
            {
                Console.WriteLine($"{item.Name}, price: {item.Price} EUR, quantity: {item.Quantity} pcs.");
            }
        }
        private void Buy(string itemBought, int quantity)
        {
            string operationResult = ShopRepository.Buy(itemBought, quantity, _user);

            if (operationResult == "")
            {
                Console.WriteLine($"----------You just bought {quantity} {itemBought}----------");
            }
            else
            {
                Console.WriteLine(operationResult);
            }
        }
        private void Add(string itemAdded, int quantity)
        {
            ShopRepository.AddItem(itemAdded, quantity);
            Console.WriteLine($"----------You just added {quantity} {itemAdded} to the Shop----------");            
        }
    }

}
