
namespace SolidPrinciples_Task1
{
    public class LampBulb : ISwitchableDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Lamp is turned on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Lamp is turned off");
        }

    }
}
