namespace Pitstop.WebApp.RESTClients
{
    public interface ILoyaltySystemAPI
    {
        [Get("/Loyalty")]
        Task<List<Loyalty>> GetLoyalties();

        [Get("/Loyalty/GetById/{id}")]
        Task<Loyalty> GetById([AliasAs("id")] string customerId);

        [Post("/AddPoints")]
        Task AddPoints(AddPoints command);

        [Post("/AddPoints")]
        Task AddCustomer(AddCustomer command);

        [Post("/Loyalty/AddCustomer")]
        Task AddCustomer(RegisterLoyaltyCustomer command);


    }
}
