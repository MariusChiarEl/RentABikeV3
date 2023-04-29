using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RentABikeV3.Shared
{
    public class Bike
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Discount { get; set; }

        public bool Type { get; set; } // 0 -> CityBike ; 1 -> MountainBike
        
        //public List<DateTime> Rezervari { get; set; }
        //{"31 mai, 16:15", "31 mai, 18:15", "31 mai, 19:15", "31 mai, 20:15", 
    }
}
