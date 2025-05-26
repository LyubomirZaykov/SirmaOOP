using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem.Models
{
    internal class PaymentProcessor
    {
        public PaymentProcessor(User currUser, PaymentType currPaymentType)
        {
            this.CurrUser = currUser;
            this.CurrPaymentType = currPaymentType;
        }
        public User CurrUser { get; set; }
        public PaymentType CurrPaymentType { get; set; }

        public bool ValidatePayment(Payment payment)
        {
            if (payment.CurrUser == null || payment.Bill <= 0)
            {
                Console.WriteLine("Invalid payment details.");
                return false;
            }
            if (payment.CurrUser.Wallet < payment.Bill)
            {
                Console.WriteLine($"Insufficient funds in {payment.CurrUser.Name}'s wallet for the payment of {payment.Bill}.");
                return false;
            }
            string credentials = payment.CurrUser.Credentials;
            Console.WriteLine("Please enter your credentials: ");
            string input = Console.ReadLine();
            if (input != credentials)
            {
                Console.WriteLine("Invalid credentials. Payment cannot be processed.");
                return false;
            }
            else
            {
                Console.WriteLine($"Payment of {payment.Bill} is valid for user {payment.CurrUser.Name}.");
                return true;
            }
                
        }
    }
}
