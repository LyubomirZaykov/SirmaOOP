using System.Security.Cryptography.X509Certificates;

namespace SingleResponsibilityPrinciple
{
    public class PaymentProcessor
    {
        public void ProcessBankCardPayment(Order order)
        {
            Console.WriteLine($"Processing payment for {order.TotalAmount}...");
        }
    }
}
