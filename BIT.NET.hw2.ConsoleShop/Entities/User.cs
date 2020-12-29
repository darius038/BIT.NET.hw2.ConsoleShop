using System;
using System.Collections.Generic;
using System.Text;

namespace BIT.NET.hw5.ConsoleShop.Data
{
    public class User
    {
        public double Balance { get; set; }

        public User()
        {
            Balance = 100;
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Your Account Balance: {Balance} EUR");
        }
        public void TopupBalance(double topup)
        {
            Balance += topup;
            ShowBalance();
        }
    }
}
