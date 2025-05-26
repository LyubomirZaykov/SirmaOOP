using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem.Models
{
    internal class Orders
    {
        private readonly List<Order> orders = new List<Order>();

        public Orders()
        {
            orders = new List<Order>();
        }
        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
            {
                Console.WriteLine($"Denied. Order with id : \"{order.Id}\" already exists in our database.");
            }
            else
            {
                orders.Add(order);
                Console.WriteLine($"Order with \"{order.Id}\" added to our database on {order.OrderDate.ToString()}!");
            }
        }

    }
}
