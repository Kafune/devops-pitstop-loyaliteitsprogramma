﻿namespace Pitstop.WebApp.RESTClients
{
    public interface ILoyaltySystemAPI
    {
        [Get("/loyalty")]
        Task<List<Loyalty>> GetLoyalties();

        [Get("/loyalty/{id}")]
        Task<Loyalty> GetLoyaltyStatusFromCustomer([AliasAs("id")] string customerId);
        [Post("/loyalty/addpoints")]
        Task AddLoyaltyPoints([Body] AddLoyaltyPointsRequest addLoyaltyPointsRequest, AddLoyaltyPoints addLoyaltyPoints);
        [Post("/loyalty/addcustomer")]
        Task RegisterCustomerToLoyaltySystem([Body] AddCustomerToLoyaltyRequest addCustomerToLoyaltyRequest, AddCustomerToLoyalty addCustomerToLoyalty);
    }
}