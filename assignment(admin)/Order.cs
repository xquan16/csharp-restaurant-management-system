using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_admin_
{
    public class Order
    {
        public string ItemName { get; }
        public int Quantity { get; }
        public double Price { get; }
        public double TotalPrice => Quantity * Price;

        public Order(string itemName, int quantity, double price)
        {
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
        }
        public string GetOrderDescription()
        {
            return "Order: " + ItemName + ", Quantity: " + Quantity + ", Total Price: " + TotalPrice.ToString("C2");
        }
    }
}
