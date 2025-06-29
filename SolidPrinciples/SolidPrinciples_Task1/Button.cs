namespace SolidPrinciples_Task1
{
    public class Button
    {

        private readonly ISwitchableDevice device;

        public Button(ISwitchableDevice device)
        {
            this.device = device;
        }
        public void Poll()
        {
            device.TurnOn();
            device.TurnOff();
        }
        
    }
}
