using SolidPrinciples_Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        LampBulb lamp = new LampBulb();
        Fan fan = new Fan();

        Button lampButton = new Button(lamp);
        Button fanButton = new Button(fan);
    }
}