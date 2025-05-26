using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem.Models
{
    internal class ElectronicsItem : InventoryItem
    {
        public ElectronicsItem(string name, decimal price, string category, bool isPerishableItem, bool isBreakable, string id, int quantity)
            : base(name, price, category, isPerishableItem, isBreakable, id, quantity)
        {
            
        }
        public bool IsItemBroken { get; set; } = false;
        

    }
}
