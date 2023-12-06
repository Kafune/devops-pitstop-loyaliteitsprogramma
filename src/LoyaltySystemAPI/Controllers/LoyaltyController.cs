// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using Pitstop.WebApp.Models;

namespace LoyaltySystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoyaltyController : ControllerBase
    {
        LoyaltyContext _dbContext;

        public LoyaltyController(LoyaltyContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<LoyaltyController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dbContext.Loyalties.ToListAsync());
        }

        // GET api/<LoyaltyController>/5
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var loyalty = await _dbContext.Loyalties.FirstOrDefaultAsync(c => c.CustomerID == id);
            if (loyalty == null)
            {
                return NotFound();
            }
            return Ok(loyalty);
        }

        // POST api/<LoyaltyController>/AddPoints
        [HttpPost("AddPoints")]
        public async Task<IActionResult> AddPoints([FromBody] AddLoyaltyPointsRequest addLoyaltyPointsRequest)
        {
            var customer = await _dbContext.Loyalties.FirstOrDefaultAsync(c => c.CustomerID == addLoyaltyPointsRequest.CustomerId);

            if (customer == null)
            {
                return NotFound($"Geen klant gevonden met ID: {addLoyaltyPointsRequest.CustomerId}");
            }

            int currentPoints = int.Parse(customer.Points);
            currentPoints += addLoyaltyPointsRequest.LoyaltyPoints;
            customer.Points = currentPoints.ToString();

            string customercategory = DetermineCustomercategory(currentPoints);
            customer.Category = customercategory;

            _dbContext.Update(customer);
            await _dbContext.SaveChangesAsync();

            return Ok($"Nieuw aantal punten voor klant {addLoyaltyPointsRequest.LoyaltyPoints}: {currentPoints}");
        }

        private static string DetermineCustomercategory(int points)
        {
            if (points >= 1001)
            {
                return "Platina";
            }
            else if (points >= 501)
            {
                return "Goud";
            }    
            return "Zilver";
            
        }

        // POST api/<LoyaltyController>/AddCustomer
        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer([FromBody] CustomerDto customerDto)
        {
            if (customerDto == null)
            {
                return BadRequest("Invalid customer data");
            }

            var loyalty = new Loyalty
            {
                CustomerID = customerDto.CustomerID,
                Points = "0",
                Category = "Zilver"
            };

            // Add loyalty to the database
            _dbContext.Loyalties.Add(loyalty);
            await _dbContext.SaveChangesAsync();

            return Ok($"Customer with ID {customerDto.CustomerID} added successfully");
        }
    }
}