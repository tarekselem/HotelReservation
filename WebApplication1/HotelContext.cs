using Microsoft.EntityFrameworkCore;
using HotelReservation.Models.Entities;

namespace HotelReservation.API
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DtoGuest> Guests { get; set; }
        public DbSet<DtoReservation> Reservations { get; set; }
        public DbSet<DtoRoom> Rooms { get; set; }
        public DbSet<DtoRoomType> RoomTypes { get; set; }
    }
}
