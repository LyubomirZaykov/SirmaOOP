using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class CreditCard : IPaymentMethod, IRefundable
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
        public void Refund(double amount)
        {
            Console.WriteLine($"Refunded {amount} to Credit Card.");
        }
    }
}
