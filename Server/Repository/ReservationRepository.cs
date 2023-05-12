using RentABikeV3.Server.Data;
using RentABikeV3.Shared;
using RentABikeV3.Server.Interfaces;

namespace RentABikeV3.Server.Repository
{
    public class ReservationRepository : IReservationRepository
    {
        RentABikeV3ServerContext _context;

        public ReservationRepository(RentABikeV3ServerContext context)
        {
            _context = context;
        }
        public void AddReservation(Reservation newReservation)
        {
            _context.Reservations.Add(newReservation);
            _context.SaveChanges();
        }

        public void DeleteReservation(int id)
        {
            var reservation = _context.Reservations.FirstOrDefault(x => x.Id == id);
            if (reservation == null)
                return;

            _context.Reservations.Remove(reservation);
            _context.SaveChanges();
        }

        public List<Reservation> GetAllReservations()
        {
            return _context.Reservations.OrderBy(x => x.Id).ToList();
        }

        public Reservation? GetSingleReservation(int id)
        {
            return _context.Reservations.FirstOrDefault(reservation => reservation.Id == id);
        }

    }
}
