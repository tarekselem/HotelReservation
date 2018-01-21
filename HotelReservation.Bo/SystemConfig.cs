using HotelReservation.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HotelReservation.Bo
{
    public static class SystemConfig
    {
        public static void ConfigureDb(IServiceCollection services)
        {
            var connection = @"Password=123;Persist Security Info=True;User ID=task;Initial Catalog=taskDB;Data Source=52.178.217.7";
            services.AddDbContext<HotelContext>(options => options.UseSqlServer(connection));
        }
    }
}
