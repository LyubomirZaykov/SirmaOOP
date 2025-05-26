using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem.Models
{
    internal class FragileItem : InventoryItem
    {
        internal FragileItem(string name, decimal price, string category, bool isPerishable, bool isBreakable, string id, int quantity, double weight) : base(name, price, category, isPerishable, isBreakable, id, quantity)
        {
            this.Weight=weight;
        }
        public bool IsItemBroken { get; set; } = false;
        public override void Break()
        {
            if (IsBreakable)
            {
                if (IsItemBroken)
                {
                    Console.WriteLine("The item is already broken.");
                }
                else
                {
                    IsItemBroken = true;
                    Console.WriteLine("The item has been marked as broken.");
                }
            }
        }
        public double Weight { get; set; }
    }
}
