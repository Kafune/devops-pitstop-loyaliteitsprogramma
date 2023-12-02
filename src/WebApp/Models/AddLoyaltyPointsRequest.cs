namespace Pitstop.WebApp.Models
{
    public class AddLoyaltyPointsRequest
    {
        public string CustomerId { get; set; }
        public int LoyaltyPoints { get; set; }
    }
}
