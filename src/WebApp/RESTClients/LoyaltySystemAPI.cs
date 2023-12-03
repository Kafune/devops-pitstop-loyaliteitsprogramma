using System.Net.Http;

namespace Pitstop.WebApp.RESTClients
{
    public class LoyaltySystemAPI : ILoyaltySystemAPI
    {
        private ILoyaltySystemAPI _restClient;

        public LoyaltySystemAPI(IConfiguration config, HttpClient httpClient)
        {
            string apiHostAndPort = config.GetSection("APIServiceLocations").GetValue<string>("LoyaltySystemAPI");
            httpClient.BaseAddress = new Uri($"http://{apiHostAndPort}/api");
            _restClient = RestService.For<ILoyaltySystemAPI>(
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
        public async Task AddLoyaltyPoints([Body] AddLoyaltyPointsRequest addLoyaltyPointsRequest, AddLoyaltyPoints command)
        {
            await _restClient.AddLoyaltyPoints(addLoyaltyPointsRequest, command);
        }

        public Task<Loyalty> GetLoyaltyStatusFromCustomer([AliasAs("id")] string customerId)
        {
            throw new NotImplementedException();
        }

        public async Task RegisterCustomerToLoyaltySystem([Body] AddCustomerToLoyaltyRequest addCustomerToLoyaltyRequest, AddCustomerToLoyalty addCustomerToLoyalty)
        {
            await _restClient.RegisterCustomerToLoyaltySystem(addCustomerToLoyaltyRequest, addCustomerToLoyalty);
        }
    }
}
