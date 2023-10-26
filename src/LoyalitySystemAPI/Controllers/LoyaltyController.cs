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
    // Haal de huidige punten op met behulp van het GetById endpoint
    var loyalty = await _dbContext.Loyalties.FirstOrDefaultAsync(c => c.CustomerID == customerId);

    // Controleer of de loyalty-entry bestaat
    if (loyalty == null)
    {
        return NotFound($"Geen klant gevonden met ID: {customerId}");
    }

    // Haal de huidige punten op uit het Loyalty-object
    int currentPoints = int.Parse(loyalty.Points);

    // Voeg de nieuwe punten toe
    currentPoints += pointsToAdd;

    // Update het Loyalty-object in de database
    loyalty.Points = currentPoints.ToString();
    _dbContext.Update(loyalty);
    await _dbContext.SaveChangesAsync();

    // Geef een succesbericht terug met het nieuwe aantal punten
    return Ok($"Nieuw aantal punten voor klant {customerId}: {currentPoints}");
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
