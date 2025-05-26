using InventoryManagmentSystem.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Users users = new Users();
        Item item=new ElectronicsItem("Dell", 999.99m, "Laptops",false,true, "XPS 13", 1);
        User user1 = new User("Ivan", 5000m);
        User user2 = new User("Petar", 3000m);
        Console.WriteLine($"Id of user1 is {user1.Id}, and that of user2 is {user2.Id}");
  

    }
}