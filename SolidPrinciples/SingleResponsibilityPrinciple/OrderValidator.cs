
namespace SingleResponsibilityPrinciple
{
    public class OrderValidator
    {
        public void Validate(Order order)
        {
            if(order.Items.Count == 0)
            {
                throw new ArgumentException("Order must contain at least one item.");
            }

            if (order.TotalAmount <= 0)
            {
                throw new ArgumentException("Order total amount must be greater than zero.");
            }

        }
    }
}
