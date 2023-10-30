using Pitstop.WebApp.RESTClients;

namespace WebApp.RESTClients;

public class LoyaltySystemAPI : ILoyaltySystemAPI
{
    private ILoyaltySystemAPI _restClient;

    public LoyaltySystemAPI(IConfiguration config, HttpClient httpClient)
    {
        string apiHostAndPort = config.GetSection("APIServiceLocations").GetValue<string>("LoyaltySystemAPI");
        httpClient.BaseAddress = new Uri($"http://{apiHostAndPort}/api");
        _restClient = (ILoyaltySystemAPI)RestService.For<ILoyaltySystemAPI>(
            httpClient,
            new RefitSettings
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer()
            });
    }

    public async Task<List<Loyalty>> GetLoyalties()
    {
        return await _restClient.GetLoyalties();
    }

    public async Task<Loyalty> GetById([AliasAs("id")] string customerId)
    {
        try
        {
            return await _restClient.GetById(customerId);
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

    public async Task AddCustomer(AddCustomer command)
    {
        await _restClient.AddCustomer(command);
    }

    public async Task AddPoints(AddPoints command)
    {
        await _restClient.AddPoints(command);
    }

}