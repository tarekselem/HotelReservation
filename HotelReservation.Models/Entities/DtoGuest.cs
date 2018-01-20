namespace HotelReservation.Models.Entities
{
    public class DtoGuest : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}