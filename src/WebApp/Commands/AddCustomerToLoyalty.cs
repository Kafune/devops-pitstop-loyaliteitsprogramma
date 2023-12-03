namespace Pitstop.WebApp.Commands
{
    public class AddCustomerToLoyalty : Command
    {
        public readonly string CustomerId;


        public AddCustomerToLoyalty(Guid messageId, string customerId) : base(messageId)
        {
            CustomerId = customerId;
        }
    }
}
