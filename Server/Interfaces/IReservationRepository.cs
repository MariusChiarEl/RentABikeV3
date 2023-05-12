using RentABikeV3.Shared;

namespace RentABikeV3.Server.Interfaces
{
    public interface IReservationRepository
    {
        List<Reservation> GetAllReservations();
        Reservation? GetSingleReservation(int id);
        void AddReservation(Reservation newReservation);
        void DeleteReservation(int id);
    }
}
