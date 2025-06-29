namespace LiskovSubstitution;
internal class Program
{
    private static void Main(string[] args)
    {
        BankTransfer bankTransfer = new BankTransfer();
        CreditCard creditCard = new CreditCard();
        List<IPaymentMethod> paymentMethods = new List<IPaymentMethod>
        {
            bankTransfer,
            creditCard
        };
        foreach (IPaymentMethod method in paymentMethods)
        {
            method.Pay(150);
            
        }
        creditCard.Refund(50);
    }
}