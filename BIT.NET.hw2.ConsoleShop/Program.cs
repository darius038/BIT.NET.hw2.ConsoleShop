using BIT.NET.hw5.ConsoleShop.Data;
using BIT.NET.hw5.ConsoleShop.Services;
using System;

namespace BIT.NET.hw2.ConsoleShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            var shopServices = new ShopService();
            //Select one print service and inject to Shop
            var consolePrint = new PrintService();
            var filePrint = new PrintToFileService();
            

            var shop = new Shop(user, shopServices, filePrint);
            shop.Start();
        }
    }
}
