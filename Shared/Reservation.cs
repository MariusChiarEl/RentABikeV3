using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABikeV3.Shared
{
    public class Reservation
    {
        public int Id { get; set; }
        public int BikeId { get; set; }
        public string UserName { get; set; }

        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set; }
        public string ValidateReservation(string userName, DateTime rentStart, DateTime rentEnd)
        {

            if (string.IsNullOrEmpty(userName))
            {
                return "Name not inserted!";
            }
			int rentDay = rentEnd.Subtract(rentStart).Days;
            if (rentDay > 2) return "Rent period too long. Must be at most 48H";
			else if(rentDay!=0) return "OK!";

			int rentTime = rentEnd.Subtract(rentStart).Hours;

            if (rentTime < 1) return "Rent period too short. Must be at least 1H";


            return "OK!";
        }
    }
}
