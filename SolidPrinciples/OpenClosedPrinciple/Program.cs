namespace OpenClosedPrinciple;
public class Program
{
    private static void Main(string[] args)
    {
            DiscountService discountService = new DiscountService();
        SeasonDiscount seasonDiscount = new SeasonDiscount();
        SeniorDiscount seniorDiscount = new SeniorDiscount();
        StudentDiscount studentDiscount = new StudentDiscount();


        discountService.CalculateDiscount(100, seasonDiscount);
        discountService.CalculateDiscount(100, seniorDiscount);
        discountService.CalculateDiscount(100, studentDiscount);

    }
}