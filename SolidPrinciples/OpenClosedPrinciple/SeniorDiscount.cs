using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class SeniorDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double totalAmount)
        {
            // Assuming a 15% discount for seniors
            double discountRate = 0.15;
            return totalAmount * discountRate;
        }

    }
}
