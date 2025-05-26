using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem.Interfaces
{
    internal interface IItem
    {
        void GetDetails();
        void CalculatingValue();
        void DisplayDescription();
    }
}
