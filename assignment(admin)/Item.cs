using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_admin_
{
    public class Item
    {
        public string Name { get; }
        public double Price { get; }
        public DomainUpDown Control { get; }

        public Item(string name, double price, DomainUpDown control)
        {
            Name = name;
            Price = price;
            Control = control;
        }

        public int GetQuantity()
        {
            return int.TryParse(Control.Text, out int quantity) ? quantity : 0;
        }
    }
}
