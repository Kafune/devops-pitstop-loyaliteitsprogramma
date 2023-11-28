using Pitstop.WebApp.RESTClients;
namespace PitStop.WebApp.Controllers;
public class LoyaltyProgramController : Controller
{

    private readonly ILoyaltySystemAPI _loyaltySystemAPI;
    private readonly Microsoft.Extensions.Logging.ILogger _logger;
    private ResiliencyHelper _resiliencyHelper;

    public LoyaltyProgramController(ILoyaltySystemAPI loyaltySystemAPI, ILogger<LoyaltyProgramController> logger)
    {
        _loyaltySystemAPI = loyaltySystemAPI;
        _logger = logger;
        _resiliencyHelper = new ResiliencyHelper(_logger);
    }


    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return null;
        return await _resiliencyHelper.ExecuteResilient(async () =>
        {
            var model = new LoyaltyManagementViewModel
            {
                Loyalty = await _loyaltySystemAPI.GetLoyalties()
            };
            return View(model);
        }, View("Offline", new LoyaltyManagementOfflineViewModel()));
    }
}
