// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoyalitySystemAPI.Controllers
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
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var loyalty = await _dbContext.Loyalties.FirstOrDefaultAsync(c => c.CustomerID == id);
            if (loyalty == null)
            {
                return NotFound();
            }
            return Ok(loyalty);
        }

        // POST api/<LoyaltyController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            return Ok();
            //return Ok(await _dbContext.Loyalties);
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
