using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem.Models
{
    internal class Users
    {
        private readonly List<User> users = new List<User>();

        public Users()
        {
            users = new List<User>();   
        }
        public void AddUser(User user)
        {
            if (users.Contains(user))
            {
                Console.WriteLine($"Denied. User with name : \"{user.Name}\" already exists in our database.");
            }
            else
            {
                users.Add(user);
                Console.WriteLine($"User with \"{user.Name}\" added to our database!");
            }
        }
        public void UpdateInfo(User user)
        {
            int currId=user.Id;
            if (users.Contains(user))
            {
                User? userToUpdate = users.FirstOrDefault(u => u.Id == currId);
                if (userToUpdate!=null)
                {
                    userToUpdate.Wallet = user.Wallet;
                }
            }
            else
            {
                Console.WriteLine("There is no such user!");
            }
        }
    }
}
