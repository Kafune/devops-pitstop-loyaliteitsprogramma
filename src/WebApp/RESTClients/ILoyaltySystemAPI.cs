namespace Pitstop.WebApp.RESTClients
{
    public interface ILoyaltySystemAPI
    {
        [Get("/loyalty")]
        Task<List<Customer>> GetCustomers();

        [Get("/customers/{id}")]
        Task<Customer> GetCustomerById([AliasAs("id")] string customerId);

        [Post("/customers")]
        Task RegisterCustomer(RegisterCustomer command);
    }
}
