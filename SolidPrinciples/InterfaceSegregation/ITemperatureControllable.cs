using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface ITemperatureControllable
    {
        void SetTemperature(double temperature);
    }
}
