namespace LiskovSubstitution
{
    public class BankTransfer : IPaymentMethod
    {
        public void Pay(double amount)
        {
            // Logic for bank transfer payment
            Console.WriteLine($"Paid {amount} via Bank Transfer.");
        }
    }
}
