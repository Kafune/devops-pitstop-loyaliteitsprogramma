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
        public async Task<IActionResult> AddPoints([FromBody] LoyaltyPointsRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.CustomerID) || request.Points <= 0)
            {
                return BadRequest("Invalid request data.");
            }

            var loyalty = await _dbContext.Loyalties.FirstOrDefaultAsync(c => c.CustomerID == request.CustomerID);
            if (loyalty == null)
            {
                return NotFound("User not found.");
            }
            loyalty.Points += request.Points;

            try
            {
                await _dbContext.SaveChangesAsync();
                return Ok("Punten zijn succesvol toegevoegd.");
            }
            catch (Exception ex)
            {        
                Console.WriteLine($"Fout bij het opslaan van punten: {ex.Message}");
                return StatusCode(500, "Interne serverfout bij het opslaan van punten.");
            }
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
