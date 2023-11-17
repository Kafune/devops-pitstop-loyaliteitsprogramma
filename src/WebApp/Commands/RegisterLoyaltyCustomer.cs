namespace Pitstop.WebApp.Commands;

public class RegisterLoyaltyCustomer : Command
{
    public readonly string CustomerId;

    public RegisterLoyaltyCustomer(Guid messageId, string customerId) : base(messageId)
    {
        CustomerId = customerId;
    }
}