using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    Name = "Albania",
                    ShortName = "AL"
                },
                new Country
                {
                    CountryId = 2,
                    Name = "Kosovo",
                    ShortName = "KS"
                },
                new Country
                {
                    CountryId = 3,
                    Name = "North Macedonia",
                    ShortName = "MKD"
                });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelId = 1,
                    Name = "Hilton",
                    Address = "Tirana",
                    Rating = 4.5,
                    CountryId = 1
                },
                new Hotel
                {
                    HotelId = 2,
                    Name = "Diamond",
                    Address = "Prishtina",
                    Rating = 4.5,
                    CountryId = 2
                },
                new Hotel
                {
                    HotelId = 3,
                    Name = "Marriott",
                    Address = "Skopje",
                    Rating = 4.5,
                    CountryId = 3
                });

        }

        
    }
}
