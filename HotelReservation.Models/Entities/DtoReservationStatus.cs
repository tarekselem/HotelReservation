namespace HotelReservation.Models.Entities
{
    public class DtoReservationStatus : BaseEntity
    {
        public ReservationStatus ReservationStatus { get; set; }
        public double Fees { get; set; }
    }
}