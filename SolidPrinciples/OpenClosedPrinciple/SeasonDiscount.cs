using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class SeasonDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double totalAmount)
        {
            // Assuming a 20% discount for seasonal sales
            double discountRate = 0.20;
            return totalAmount * discountRate;
        }
    }
}
