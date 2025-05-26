using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem.Models
{
    internal class InventoryItem : Item
    {
        internal InventoryItem(string name, decimal price, string category, bool isPerishable, bool isBreakable, string id, int quantity) : base(name, price, category, isPerishable, isBreakable)
        {
            Id = id;
            Quantity = quantity;

        }

        public string Id { get; set; }
        public int Quantity { get; set; }
    }
}
