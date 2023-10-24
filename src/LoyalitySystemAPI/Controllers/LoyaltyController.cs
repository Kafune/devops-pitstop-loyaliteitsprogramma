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
        }
        // GET: api/<LoyaltyController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dbContext.Loyalties.ToListAsync());
        }

        // GET api/<LoyaltyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoyaltyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
