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

        public DbSet<RentABikeV3.Shared.Bike> Bikes { get; set; } = default!;
        public DbSet<RentABikeV3.Shared.Reservation> Reservations { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Bike>()
            //    .HasMany(e => e.Reservations)
            //    .WithOne(e => e.Bike)
            //    .HasForeignKey(e => e.BikeId);
            //    //.IsRequired();
        }
    }
}
