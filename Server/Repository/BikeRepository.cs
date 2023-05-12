using RentABikeV3.Server.Data;
using RentABikeV3.Server.Interfaces;
using RentABikeV3.Shared;

namespace RentABikeV3.Server.Repository
{
    public class BikeRepository : IBikeRepository
    {
        RentABikeV3ServerContext _context;

        public BikeRepository(RentABikeV3ServerContext context) 
        {
            _context = context;
        }
        public void AddBike(Bike newBike)
        {
            _context.Bikes.Add(newBike);
            _context.SaveChanges();
        }

        public void DeleteBike(int id)
        {
            var bike = _context.Bikes.FirstOrDefault(x => x.Id == id);
            if (bike == null)
                return;

            _context.Bikes.Remove(bike);
            _context.SaveChanges();
        }

        public List<Bike> GetAllBikes()
        {
            return _context.Bikes.OrderBy(x => x.Id).ToList();
        }

        public Bike? GetSingleBike(int id)
        {
            return _context.Bikes.FirstOrDefault(bike => bike.Id == id);
        }

        public void UpdateBike(int id, Bike bike)
        {
            var existingBike = _context.Bikes.FirstOrDefault(bike => bike.Id == id);

            if (existingBike == null)
                return;
            /*
            existingBike.Rezervari = bike.Rezervari;
            existingBike.Users = bike.Users;
            */
            existingBike.Price = bike.Price;
            existingBike.Id = id;

            _context.SaveChanges();
        }
    }
}
