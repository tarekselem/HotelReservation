using System;

namespace HotelReservation.Models.Entities
{
    public abstract class BaseEntity
    {
        public Guid? Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
