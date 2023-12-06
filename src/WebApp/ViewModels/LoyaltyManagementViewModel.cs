namespace Pitstop.WebApp.ViewModels
{
    public class LoyaltyManagementViewModel
    {
        public IEnumerable<Loyalty>? Loyalties { get; set; }
        public string CustomerId { get; set; }
        public string SelectedVehicleLicenseNumber { get; set; }
        public int LoyaltyPoints { get; set; }

    }
}
