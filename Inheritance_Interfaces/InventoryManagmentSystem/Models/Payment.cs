using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem.Models
{
    internal class Payment
    {
        public Payment(User user, decimal bill)
        {
                this.CurrUser = user;
            this.Bill = bill;
        }
        public User CurrUser { get; set; }
        public decimal Bill { get; set; }
        public void Pay()
        {
            if (CurrUser.Wallet >= Bill)
            {
                CurrUser.Wallet -= Bill;
                Console.WriteLine($"Payment of {Bill} made successfully by {CurrUser.Name}. Remaining wallet balance: {CurrUser.Wallet}");
            }
            else
            {
                Console.WriteLine($"Payment failed. Insufficient funds in {CurrUser.Name}'s wallet.");
            }
        }
    }
}
