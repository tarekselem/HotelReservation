using System;
using System.Collections.Generic;
using System.Text;
using HotelReservation.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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
