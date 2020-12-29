using BIT.NET.hw5.ConsoleShop.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIT.NET.hw5.ConsoleShop.Services
{
    public class Shop
    {
        private ShopService _shopServices;
        private User _user;
        private IPrintService _printer;
        public Shop(User user, ShopService shopServices, IPrintService printer)
        {
            _shopServices = shopServices;
            _user = user;
            _printer = printer;
        }
        public void Start()
        {
            _shopServices.Start(_user, _printer);
        }
    }
}
