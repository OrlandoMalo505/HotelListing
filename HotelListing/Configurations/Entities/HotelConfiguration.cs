using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(new Hotel
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
