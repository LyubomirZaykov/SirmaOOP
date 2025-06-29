namespace SingleResponsibilityPrinciple
{
    public class OrderProcessor
    {
        private readonly OrderValidator orderValidator;
        private readonly PaymentProcessor paymentProcessor;
        private readonly Notifier notifier;


        public OrderProcessor(OrderValidator orderValidator, 
            PaymentProcessor paymentProcessor, 
            Notifier notifier)
        {
            this.paymentProcessor = paymentProcessor;
            this.orderValidator = orderValidator;
            this.notifier = notifier;
        }

        public void ProcessOrder(Order order)
        {
            orderValidator.Validate(order);
            paymentProcessor.ProcessBankCardPayment(order);
            notifier.NotifyByEmail(order);
        }

    }
}
