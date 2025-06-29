
namespace DependencyInversionPriciple
{
    public class EmailSender : ISender
    {
        public void SendMessage()
        {
            Console.WriteLine("Sending email");
        }
    }
}
