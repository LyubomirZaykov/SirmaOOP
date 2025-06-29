
namespace SolidPrinciples_Task1
{
    public class Fan : ISwitchableDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan is turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Fan is turned off");
        }
    }
}
