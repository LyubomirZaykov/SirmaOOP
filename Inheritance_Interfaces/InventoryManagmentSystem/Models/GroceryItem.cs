using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem.Models
{
    internal class GroceryItem : InventoryItem
    {
        public GroceryItem(string name, decimal price, string category, bool isPerishable, bool isBreakable, string id, int quantity, DateOnly expirationDate) : base(name, price, category, isPerishable, isBreakable, id, quantity)
        {
            this.ExpirationDate = expirationDate;
        }
        public DateOnly ExpirationDate { get; set; }
        public bool IsItemExpired { get; set; } = false;

        public override void Expire()
        {
            if (DateOnly.FromDateTime(DateTime.Now) > ExpirationDate)
            {
                IsItemExpired = true;
                Console.WriteLine($"The item {base.Name} has expired on {this.ExpirationDate}.");
            }
            else
            {
                Console.WriteLine($"The item {base.Name} is still fresh until {this.ExpirationDate}.");
            }
        }
    }
}
