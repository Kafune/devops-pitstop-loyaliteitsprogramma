namespace Pitstop.WebApp.RESTClients
{
    public interface ILoyaltySystemAPI
    {
        [Get("/Loyalty")]
        Task<List<Customer>> GetLoyalties();

        [Get("/Loyalty/GetById/{id}")]
        Task<Customer> GetById([AliasAs("id")] string customerId);

        [Post("/AddPoints")]
        Task AddPoints(AddPoints command);

        [Post("/AddPoints")]
        Task AddCustomer(AddCustomer command);
    }
}
