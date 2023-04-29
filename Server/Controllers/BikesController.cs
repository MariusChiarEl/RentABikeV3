using Microsoft.AspNetCore.Mvc;
using RentABikeV3.Shared;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentABikeV3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikesController : ControllerBase
    {
        private readonly List<Bike> bikes;

        public BikesController()
        {
            bikes = new List<Bike>();
        }

        // GET: api/<BikesController>
        [HttpGet]
        public ActionResult<List<Bike>> Get()
        {
            return Ok(bikes);
        }

        // GET api/<BikesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BikesController>
        [HttpPost]
        public ActionResult Post([FromBody] Bike bike)
        {
            return CreatedAtAction("GetBike", bike);
        }

        // PUT api/<BikesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BikesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
