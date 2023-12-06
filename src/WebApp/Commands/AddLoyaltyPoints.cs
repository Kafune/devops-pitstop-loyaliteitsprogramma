namespace Pitstop.WebApp.Commands
{
    public class AddLoyaltyPoints : Command
    {
        public readonly string CustomerId;
        public readonly int LoyaltyPoints;


        public AddLoyaltyPoints(Guid messageId, string customerId, int loyaltyPoints) : base(messageId)
        {
            CustomerId = customerId;
            LoyaltyPoints = loyaltyPoints;
        }
    }
}
