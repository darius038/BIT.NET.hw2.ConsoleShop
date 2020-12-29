using BIT.NET.hw5.ConsoleShop.Data;
using BIT.NET.hw5.ConsoleShop.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIT.NET.hw5.ConsoleShop.Services
{
    public class ShopService
    {
        private List<Item> _shopList;
        private User _user;
        private IPrintService _printServices;

        public ShopService()
        {
            _shopList = ShopRepository.ShopList;
        }

        public void Start(User user, IPrintService print)
        {
            _user = user;
            _printServices = print;
            _printServices.StartMessage();

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
                        Balance();
                        break;
                    case "topup":
                        Topup(double.Parse(option[1]));
                        break;
                }
            } while (option[0] != "exit");
        }

        private string[] MainMenu()
        {
            _printServices.PrintMenu();
            string[] menuOption = Console.ReadLine().ToLower().Split(" ");
            return menuOption;
        }

        private void ViewList()
        {
            _printServices.ItemListTitle();
            foreach (var item in _shopList)
            {
                _printServices.ItemList(item.Name, item.Price, item.Quantity);
            }
        }

        private void Buy(string itemBought, int quantity)
        {
            string operationResult = ShopRepository.Buy(itemBought, quantity, _user);

            _printServices.BuyPrint(operationResult, quantity, itemBought);
        }

        private void Add(string itemAdded, int quantity)
        {
            ShopRepository.AddItem(itemAdded, quantity);
            _printServices.AddPrint(itemAdded, quantity);
        }

        private void Balance()
        {
            _printServices.BalancePrint(_user.Balance);
        }

        private void Topup(double topupAmount)
        {
            ShopRepository.TopupUserBalance(_user, topupAmount);
        }
    }

}
