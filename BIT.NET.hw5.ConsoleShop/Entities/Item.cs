using System;
using System.Collections.Generic;
using System.Text;

namespace BIT.NET.hw5.ConsoleShop.Data
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
