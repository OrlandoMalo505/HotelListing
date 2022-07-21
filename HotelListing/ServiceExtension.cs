using HotelListing.Data;
using Microsoft.AspNetCore.Identity;

namespace HotelListing
{
    public static class ServiceExtension
    {
        public static void ConfigureIdentity(this IServiceCollection services) 
        {
            var builder = services.AddIdentityCore<ApiUser>(identity => identity.User.RequireUniqueEmail = true);

            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
            builder.AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
        }
    }
}
