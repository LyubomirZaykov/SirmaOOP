using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagmentSystem.Interfaces;
namespace InventoryManagmentSystem.Models
{
    internal abstract class Item : IBreakable, IPerishable, ISellable, ICategorizable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public bool IsPerishable { get; set; }
        public bool IsBreakable { get;  set; }

        public virtual void SetPrice(decimal price)
        { 
            this.Price = price;
            Console.WriteLine($"The price of the item {this.Name} has been set to {price}.");

        }
        public virtual void GetPrice()
        {
            Console.WriteLine($"The category of the item {this.Name} is {this.Price}.");

        }
        public virtual void SetCategory(string category)
        {
            this.Category = category;
            Console.WriteLine($"The category of the item {this.Name} has been set to {this.Category}.");  
        }
        public virtual void GetCategory()
        {
            Console.WriteLine($"The category of the item {this.Name} is {this.Category}.");
        }
        public virtual void Expire()
        {
            Console.WriteLine("This is the base implementation of Expire method");
        }
        public virtual void Break()
        {
            Console.WriteLine("This is the base implementation of Break method");
        }
        internal Item(string name, decimal price, string category, bool isPerishable, bool isBreakable)
        {
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.IsBreakable = isBreakable;
            this.IsPerishable = isPerishable;
        }


    }
    
    
}
