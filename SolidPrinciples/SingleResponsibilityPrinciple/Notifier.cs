
namespace SingleResponsibilityPrinciple
{
    public class Notifier
    {
        public void NotifyByEmail(Order order)
        {
            Console.WriteLine($"Sending email notification to {order.CustomerEmail}");
        }

    }
}
