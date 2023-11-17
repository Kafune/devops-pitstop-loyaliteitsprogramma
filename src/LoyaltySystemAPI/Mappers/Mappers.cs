using LoyaltySystemAPI.Commands;

namespace LoyaltySystemAPI.Mappers;

public static class Mappers
{
    public static Loyalty MapToLoyalty(this RegisterLoyaltyCustomer loyaltyCustomer) => new Loyalty
    {
        CustomerID = loyaltyCustomer.CustomerId,
        Points = "0",
        Category = "Zilver"
    };
}

