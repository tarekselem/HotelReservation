namespace HotelReservation.Models.Entities
{
    public class DtoRoom : BaseEntity
    {
        public string Number { get; set; }
        public double Floor { get; set; }
        public DtoRoomType RoomType { get; set; }
    }
}