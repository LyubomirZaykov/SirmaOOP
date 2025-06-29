using SingleResponsibilityPrinciple;

public class Program
{
    private static void Main(string[] args)
    {
        Order order = new Order();
        order.Items = new List<string> { "T-shirt", "Jeans" };
        order.TotalAmount = 100.00;
        order.CustomerEmail = "ivan.ivanov@test-mail.com";
        OrderValidator orderValidator=new OrderValidator();
        PaymentProcessor paymentProcessor = new PaymentProcessor();
        Notifier notifier = new Notifier();

        OrderProcessor orderProcessor = new OrderProcessor(
            orderValidator, paymentProcessor, notifier
        );
        orderProcessor.ProcessOrder(order);
    }
}