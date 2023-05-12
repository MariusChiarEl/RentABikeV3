using Microsoft.EntityFrameworkCore;
using RentABikeV3.Shared;

namespace RentABikeV3.Server.Interfaces
{
    public interface IBikeRepository
    {
        List<Bike> GetAllBikes();
        Bike? GetSingleBike(int id);
        void AddBike(Bike newBike);
        void DeleteBike(int id);
        void UpdateBike(int id, Bike bike);
    }
}