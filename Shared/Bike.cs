using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABikeV3.Shared
{
    public class Bike
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Discount { get; set; }

        public string Type { get; set; } // 0 -> CityBike ; 1 -> 

        public double Price { get; set; }

        public ICollection<Reservation> Reservations { get; } = new List<Reservation>();
    }
}
