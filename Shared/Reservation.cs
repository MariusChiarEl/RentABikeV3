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

            int rentTime = rentEnd.Subtract(rentStart).Minutes;

            if (rentTime < 60) return "Rent period too short. Must be at least 1H";

            if (rentTime > 48 * 60) return "Rent period too long. Must be at most 48H";

            /*for (int i = 0; i < Rezervari.Count; i += 2)
                if ((rentEnd >= Rezervari[i] && rentEnd <= Rezervari[i + 1]) || (rentStart >= Rezervari[i] && rentStart <= Rezervari[i + 1]))
                    return "Rent overlaps other rent!";*/

            return "OK!";
        }
    }
}
