using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HotelReservation.Data.Common;

namespace HotelReservation.Bo
{
    public static class SystemConfig
    {
        public static void ConfigureDb(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<HotelContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
