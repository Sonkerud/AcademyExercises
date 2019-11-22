using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
        public  class ShoppingCartItem
    {
        public string ProductName { get; set; }

        public ShoppingCartItem(string productName)
        {
            ProductName = productName;
        }

    }
}
