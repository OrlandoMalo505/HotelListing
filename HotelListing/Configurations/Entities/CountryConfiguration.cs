using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(new Country
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

        }
    }
}
