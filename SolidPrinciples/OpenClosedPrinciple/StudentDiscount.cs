using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class StudentDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double totalAmount)
        {
            // Assuming a 10% discount for students
            double discountRate = 0.10;
            return totalAmount * discountRate;
        }
    }
}
