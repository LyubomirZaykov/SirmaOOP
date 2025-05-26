using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem.Models
{
    internal class Order
    {
        private static int initialOrderId = 1;

        public Order()
        {
            this.Items = new List<InventoryItem>();
            OrderDate = DateTime.Now;
            this.Id = initialOrderId++;
        }
        public int Id { get; private set; }
        public List<InventoryItem> Items { get; private set; }

        public DateTime OrderDate { get; private set; }
        public decimal TotalAmount => Items.Sum(item => item.Price * item.Quantity);
        public void AddItem(InventoryItem item)
        {
            if (item.Quantity > 0)
            {
                Items.Add(item);
                Console.WriteLine($"Item {item.Name} added to order. Quantity: {item.Quantity}, Price: {item.Price}");
            }
            else
            {
                Console.WriteLine($"Cannot add item {item.Name} to order. Invalid quantity: {item.Quantity}");
            }
        }
    }
}
