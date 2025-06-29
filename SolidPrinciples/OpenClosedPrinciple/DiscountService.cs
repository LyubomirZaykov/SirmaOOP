using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class DiscountService
    {
        public void CalculateDiscount(double amount, IDiscountStrategy strategy)
        {
            Console.WriteLine($"The amount to be reduced is {strategy.ApplyDiscount(amount)}");
        }
    }
}
