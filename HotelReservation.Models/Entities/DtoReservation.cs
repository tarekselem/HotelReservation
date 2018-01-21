using System;
using System.Collections.Generic;

namespace HotelReservation.Models.Entities
{
    public class DtoReservation : BaseEntity
    {
        public DtoGuest Guest { get; set; }
        public DtoRoom Room { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public ICollection<DtoReservationStatus> ReservationStatusList { get; set; }
    }
}