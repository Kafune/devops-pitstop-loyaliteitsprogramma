using Pitstop.WebApp.RESTClients;
namespace PitStop.WebApp.Controllers;
public class LoyaltyProgramController : Controller
{

    private readonly ILoyaltySystemAPI _loyaltySystemAPI;
    private readonly ICustomerManagementAPI _customerManagementAPI;
    private readonly Microsoft.Extensions.Logging.ILogger _logger;
    private ResiliencyHelper _resiliencyHelper;

    public LoyaltyProgramController(ILoyaltySystemAPI loyaltySystemAPI, ILogger<LoyaltyProgramController> logger, ICustomerManagementAPI customerManagementAPI)
    {
        _loyaltySystemAPI = loyaltySystemAPI;
        _logger = logger;
        _resiliencyHelper = new ResiliencyHelper(_logger);
        _customerManagementAPI = customerManagementAPI;
    }


    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return await _resiliencyHelper.ExecuteResilient(async () =>
        {
            CustomerManagementViewModel customerModel = new()
            {
                Customers = await _customerManagementAPI.GetCustomers()
            };
            LoyaltyManagementViewModel loyaltyModel = new()
            {
                Loyalties = await _loyaltySystemAPI.GetLoyalties()
            };
            LoyaltyCustomerViewModel model = new()
            {
                CustomerManagementViewModel = customerModel,
                LoyaltyManagementViewModel = loyaltyModel
            };
            return View(model);
        }, View("Offline", new LoyaltyManagementOfflineViewModel()));
    }
}
