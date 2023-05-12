using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using RentABikeV3.Shared;
using RentABikeV3.Server.Interfaces;

namespace RentABikeV3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeController : ControllerBase
    {
        private readonly IBikeRepository bikeRepository;

        public BikeController(IBikeRepository bikeRepository)
        {
            this.bikeRepository = bikeRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Bike>>> GetAllBikes()
        {
            var result = bikeRepository.GetAllBikes();
            if (result is null) return NotFound();
            return Ok(result);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Bike>> GetSingleBike(int id)
        {
            var result = bikeRepository.GetSingleBike(id);
            if (result is null) return NotFound();
            return Ok(result);

        }
        [HttpPost]
        public async Task<ActionResult<List<Bike>>> AddBike(Bike bike)
        {
            if(bike == null)
                return BadRequest("No bike!");

            bikeRepository.AddBike(bike);

            return Ok();

        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Bike>>> UpdateBike(int id, Bike bike)
        {
            if (bike == null)
                return BadRequest("No bike!");
            bikeRepository.UpdateBike(id, bike);

            return Ok();
        }
        [HttpDelete]
        public async Task<ActionResult<List<Bike>>> DeleteBike(int id)
        {
            if (id == null)
                return BadRequest("No bike!");

            bikeRepository.DeleteBike(id);

            return Ok();
        }

    }
}