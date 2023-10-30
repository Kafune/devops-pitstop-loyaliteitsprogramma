namespace PitStop.Controllers;

public class LoyaltyProgramController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
