using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem.Models
{
    internal class User
    {
        private static int initialId = 1;
        internal User(string name, decimal wallet)
        {
            this.Name = name;
            this.Wallet = wallet;
            this.Id = initialId++;
        }
        public int Id { get; private set; }
        internal decimal Wallet { get; set; }
        internal string Name { get; set; }
    }
}
