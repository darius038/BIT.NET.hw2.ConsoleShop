using BIT.NET.hw2.ConsoleShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIT.NET.hw2.ConsoleShop.Repository
{
    public static class ShopRepository
    {
        public static List<Item> ShopList = new List<Item>()
        {
            new Book ()
            {
                Name = "Very interesting Book",
                Quantity = 5,
                Price = 12.2
            },
             new Cup ()
            {
                Name = "Big Cup",
                Quantity = 8,
                Price = 1.8
            },
              new Candy ()
            {
                Name = "Seet Candy",
                Quantity = 55,
                Price = 0.5
            }
        };

        public static string Buy(string item, int quantity, User user)
        {
            string operation="";
            switch (item)
            {
                case "cup": 
                    var cup = ShopList.FirstOrDefault(i =>i is Cup); 
                    if (cup.Quantity < quantity)
                    {
                        operation = "Insufficient quantity!";
                        break;
                    }
                    else if (cup.Quantity*cup.Price>user.Balance)
                    {
                        operation = "Insufficient funds in Your card balance!";
                        break;
                    } else
                    {
                        cup.Quantity -= quantity;
                        user.Balance -= quantity * cup.Price;
                        break;
                    }
                case "candy":
                    var candy = ShopList.FirstOrDefault(i => i is Candy);
                    if (candy.Quantity < quantity)
                    {
                        operation = "Insufficient quantity!";
                        break;
                    }
                    else if (candy.Quantity * candy.Price > user.Balance)
                    {
                        operation = "Insufficient funds in Your card balance!";
                        break;
                    }
                    else
                    {
                        candy.Quantity -= quantity;
                        user.Balance -= quantity * candy.Price;
                        break;
                    }
                case "book":
                    var book = ShopList.FirstOrDefault(i => i is Book);
                    if (book.Quantity < quantity)
                    {
                        operation = "Insufficient quantity!";                        
                        break;
                    }
                    else if (book.Quantity * book.Price > user.Balance)
                    {
                        operation = "Insufficient funds in Your card balance!";
                        break;
                    }
                    else
                    {
                        book.Quantity -= quantity;
                        user.Balance -= quantity * book.Price;
                        break;
                    }
            }
            return operation;
        }

        public static void TopupUserBalance (User user, double amount)
        {
            user.Balance += amount;
            Console.WriteLine($"Your balance {user.Balance} EUR");

        }

        public static void AddItem(string item, int quantity)
        {
            switch (item)
            {
                case "cup":
                    var cup = ShopList.FirstOrDefault(i => i is Cup);
                    cup.Quantity += quantity;
                    break;
                case "candy":
                    var candy = ShopList.FirstOrDefault(i => i is Candy);
                    candy.Quantity += quantity;
                    break;
                case "book":
                    var book = ShopList.FirstOrDefault(i => i is Book);
                    book.Quantity += quantity;
                    break;
            }
        }
    }
}
