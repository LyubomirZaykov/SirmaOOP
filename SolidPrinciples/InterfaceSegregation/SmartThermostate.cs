using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class SmartThermostate : ISwitchable, ITemperatureControllable
    {
        public void SetTemperature(double temperature)
        {
            Console.WriteLine($"The temperature is set to {temperature} degrees Celsium");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn thermostate off"); 
        }

        public void TurnOn()
        {
            Console.WriteLine("Turn thermostate on"); 
        }
    }
}
