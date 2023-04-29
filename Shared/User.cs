using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABikeV3.Shared
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public RentedBike? Bike { get; set; }
    }
}
