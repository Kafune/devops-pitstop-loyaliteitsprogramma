using Pitstop.WebApp.RESTClients;

namespace WebApp.RESTClients;

public class LoyaltySystemAPI : ICustomerManagementAPI
{
    private ILoyaltySystemAPI _restClient;

    public LoyaltySystemAPI(IConfiguration config, HttpClient httpClient)
    {
        string apiHostAndPort = config.GetSection("APIServiceLocations").GetValue<string>("CustomerManagementAPI");
        httpClient.BaseAddress = new Uri($"http://{apiHostAndPort}/api");
        _restClient = (ILoyaltySystemAPI)RestService.For<ICustomerManagementAPI>(
            httpClient,
            new RefitSettings
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer()
            });
    }

    public async Task<List<Customer>> GetCustomers()
    {
        return await _restClient.GetCustomers();
    }

    public async Task<Customer> GetCustomerById([AliasAs("id")] string customerId)
    {
        try
        {
            return await _restClient.GetCustomerById(customerId);
        }
        catch (ApiException ex)
        {
            if (ex.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
            else
            {
                throw;
            }
        }
    }

    public async Task RegisterCustomer(RegisterCustomer command)
    {
        await _restClient.RegisterCustomer(command);
    }
}