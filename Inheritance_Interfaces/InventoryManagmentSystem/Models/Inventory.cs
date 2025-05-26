using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem.Models
{
    internal class Inventory
    {
        public readonly List<InventoryItem> items = new List<InventoryItem>();
        public Inventory()
        {
            items = new List<InventoryItem>();
        }
        public void AddItem(InventoryItem item)
        {
            if (items.Contains(item))
            {
                Console.WriteLine($"Denied. Item with name : \"{item.Name}\" already exists in our inventory.");
            }
            else
            {
                items.Add(item);
                Console.WriteLine($"Item with \"{item.Name}\" added to our inventory!");
            }
        }
        public void RemoveItem(InventoryItem item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine($"Item with \"{item.Name}\" removed from our inventory!");
            }
            else
            {
                Console.WriteLine($"Denied. Item with name : \"{item.Name}\" does not exist in our inventory.");
            }
        }
        public void ShowInventory()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("The inventory is empty.");
            }
            else
            {
                Console.WriteLine("Current Inventory:");
                foreach (var item in items)
                {
                    Console.WriteLine($"- {item.Name} (ID: {item.Id}, Price: {item.Price}, Quantity: {item.Quantity})");
                }
            }
        }
        public InventoryItem FindItemById(string id)
        {
            return items.FirstOrDefault(item => item.Id == id);
        }
        public InventoryItem FindItemByName(string name)
        {
            return items.FirstOrDefault(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
        public void UpdateItemQuantity(string id, int newQuantity)
        {
            var item = FindItemById(id);
            if (item != null)
            {
                item.Quantity = newQuantity;
                Console.WriteLine($"Updated quantity of {item.Name} to {newQuantity}.");
            }
            else
            {
                Console.WriteLine($"Item with ID {id} not found in inventory.");
            }
        }
        public void UpdateItemPrice(string id, decimal newPrice)
        {
            var item = FindItemById(id);
            if (item != null)
            {
                item.Price = newPrice;
                Console.WriteLine($"Updated price of {item.Name} to {newPrice:C}.");
            }
            else
            {
                Console.WriteLine($"Item with ID {id} not found in inventory.");
            }
        }
        public void UpdateItemCategory(string id, string newCategory)
        {
            var item = FindItemById(id);
            if (item != null)
            {
                item.Category = newCategory;
                Console.WriteLine($"Updated category of {item.Name} to {newCategory}.");
            }
            else
            {
                Console.WriteLine($"Item with ID {id} not found in inventory.");
            }
        }
        public void ClearInventory()
        {
            items.Clear();
            Console.WriteLine("All items have been removed from the inventory.");
        }
        public void ShowItemDetails(string id)
        {
            var item = FindItemById(id);
            if (item != null)
            {
                Console.WriteLine($"Item Details:\n- Name: {item.Name}\n- ID: {item.Id}\n- Price: {item.Price:C}\n- Category: {item.Category}\n- Quantity: {item.Quantity}");
                if (item is GroceryItem groceryItem)
                {
                    Console.WriteLine($"- Expiration Date: {groceryItem.ExpirationDate}");
                }
                else if (item is FragileItem fragileItem)
                {
                    Console.WriteLine($"- Weight: {fragileItem.Weight} kg");
                }
            }
            else
            {
                Console.WriteLine($"Item with ID {id} not found in inventory.");
            }
        }
        public void ShowItemsByCategory(string category)
        {
            var categorizedItems = items.Where(item => item.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
            if (categorizedItems.Count == 0)
            {
                Console.WriteLine($"No items found in the category: {category}");
            }
            else
            {
                Console.WriteLine($"Items in category '{category}':");
                foreach (var item in categorizedItems)
                {
                    Console.WriteLine($"- {item.Name} (ID: {item.Id}, Price: {item.Price}, Quantity: {item.Quantity})");
                }
            }
        }
    }
}
