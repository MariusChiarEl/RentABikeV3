using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RentABikeV3.Shared
{
    public class RentedBike : Bike
    {
        public DateTime RentStart { get; set; } // ex. "31 mai, 16:30"
        public DateTime RentEnd { get; set; } // ex. "1 iunie, 18:45"

        public double RentPrice { get; set; }

        public RentedBike(String Model, DateTime RentStart, DateTime RentEnd, double RentPrice)
        {
            this.RentStart = RentStart;
            this.RentEnd = RentEnd;

            this.Model = Model;

            this.RentPrice = RentPrice;

            if (this.IsValid() == "Valid!")
            {
                if (RentTime() >= 4 * 60)
                    RentPrice -= RentPrice * Discount;
            }
        }

        public int RentTime()
        {
            return RentEnd.Subtract(RentStart).Minutes;
        }

        public string IsValid()
        {
            if (RentTime() < 60) return "Rent period too short. Must be at least 1H";

            if (RentTime() > 48 * 60) return "Rent period too long. Must be at most 48H";

            if (Model == null) return "Please select a bike.";

            return "Valid!";
        }
    }
}
