using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public interface IRefundable
    {
        void Refund(double amount);

    }
}
