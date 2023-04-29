using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentABikeV3.Shared;

namespace RentABikeV3.Server.Data
{
    public class RentABikeV3ServerContext : DbContext
    {
        public RentABikeV3ServerContext (DbContextOptions<RentABikeV3ServerContext> options)
            : base(options)
        {
        }

        public DbSet<RentABikeV3.Shared.Bike> Bike { get; set; } = default!;
    }
}
