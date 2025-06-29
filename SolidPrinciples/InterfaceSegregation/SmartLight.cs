using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class SmartLight : ISwitchable
    {
        public void TurnOff()
        {
            Console.WriteLine("Turn light off");

        }

        public void TurnOn()
        {
            Console.WriteLine("Turn light on");
        }
    }
}
