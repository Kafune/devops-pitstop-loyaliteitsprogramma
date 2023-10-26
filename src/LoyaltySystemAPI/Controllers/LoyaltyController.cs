// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
            Console.WriteLine(_dbContext);
        }

        // GET: api/<LoyaltyController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Console.WriteLine(_dbContext);
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
        public async Task<IActionResult> AddPoints([FromQuery] string customerId, [FromQuery] int pointsToAdd)
        {
            var loyalty = await _dbContext.Loyalties.FirstOrDefaultAsync(c => c.CustomerID == customerId);

            if (loyalty == null)
            {
                return NotFound($"Geen klant gevonden met ID: {customerId}");
            }

            int currentPoints = int.Parse(loyalty.Points);
            currentPoints += pointsToAdd;
            loyalty.Points = currentPoints.ToString();

            string customercategory = DetermineCustomercategory(currentPoints);
            loyalty.Category = customercategory;

            _dbContext.Update(loyalty);
            await _dbContext.SaveChangesAsync();

            return Ok($"Nieuw aantal punten voor klant {customerId}: {currentPoints}");
        }

        private string DetermineCustomercategory(int points)
        {
            if (points >= 1001)
            {
                return "Platina";
            }
            else if (points >= 501)
            {
                return "Goud";
            }
            else
            {
                return "Zilver";
            }
        }

        // POST api/<LoyaltyController>/AddCustomer
        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer([FromBody] CustomerDto customerDto)
        {
            if (customerDto == null)
            {
                return BadRequest("Invalid customer data");
            }

            // Map the DTO to your Loyalty entity or create a new Loyalty entity
            var loyalty = new Loyalty
            {
                CustomerID = customerDto.CustomerID,
                // Set other properties of the loyalty entity based on the customerDto
                // For example: loyalty.Name = customerDto.Name;
                // Set default points and category if needed
                Points = "0",
                Category = "Zilver"
            };

            // Add loyalty to the database
            _dbContext.Loyalties.Add(loyalty);
            await _dbContext.SaveChangesAsync();

            return Ok($"Customer with ID {customerDto.CustomerID} added successfully");
        }



        // PUT api/<LoyaltyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoyaltyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
