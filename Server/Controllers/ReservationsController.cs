using Microsoft.AspNetCore.Mvc;
using RentABikeV3.Server.Interfaces;
using RentABikeV3.Server.Repository;
using RentABikeV3.Shared;

namespace RentABikeV3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : Controller
    {


        private readonly IReservationRepository reservationsRepository;

        public ReservationsController(IReservationRepository reservationsRepository)
        {
            this.reservationsRepository = reservationsRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Reservation>>> GetAllReservations()
        {
            var result = reservationsRepository.GetAllReservations();
            if (result is null) return NotFound();
            return Ok(result);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> GetSingleReservation(int id)
        {
            var result = reservationsRepository.GetSingleReservation(id);
            if (result is null) return NotFound();
            return Ok(result);

        }
        [HttpPost]
        public async Task<ActionResult<List<Reservation>>> AddReservation(Reservation reservation)
        {
            if (reservation == null)
                return BadRequest("No reservation!");

            reservationsRepository.AddReservation(reservation);

            return Ok();

        }
        [HttpDelete]
        public async Task<ActionResult<List<Reservation>>> DeleteReservation(int id)
        {
            if (id == null)
                return BadRequest("No bike!");

            reservationsRepository.DeleteReservation(id);

            return Ok();
        }
    }
}
