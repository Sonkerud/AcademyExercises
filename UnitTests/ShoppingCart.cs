using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
        public class ShoppingCart
    {
        List<ShoppingCartItem> items = new List<ShoppingCartItem>();
        public int TotalCount { get { return items.Count; } }

        public void AddItem(ShoppingCartItem item)
        {
            items.Add(item);
        }

        public ShoppingCart()
        {
            
        }
    }
}
