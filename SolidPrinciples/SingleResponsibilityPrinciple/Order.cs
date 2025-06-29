
namespace SingleResponsibilityPrinciple
{
    public class Order
    {
        public List<string> Items { get; set; } = new List<string>();
        public double TotalAmount { get; set; }
        public string CustomerEmail { get; set; }
    }
}
