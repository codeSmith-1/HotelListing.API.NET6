using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    CountryCode = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Cuba",
                    CountryCode = "CU"
                },
                new Country
                {
                    Id = 3,
                    Name = "Cayman Islands",
                    CountryCode = "CI"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandas Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5,
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Inn",
                    Address = "George Town",
                    CountryId = 3,
                    Rating = 2.5,
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Motel 8",
                    Address = "Bay Town",
                    CountryId = 2,
                    Rating = 4.1,
                }
            );
        }
    }
}
