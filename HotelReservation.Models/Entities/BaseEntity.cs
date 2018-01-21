using System;
using System.Collections.Generic;

namespace HotelReservation.Models.Entities
{
    public abstract class BaseEntity
    {
        public Guid? Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public override bool Equals(object obj)
        {
            return ((BaseEntity)obj).Id == Id && ((BaseEntity)obj).Id.HasValue;
        }

        public override int GetHashCode()
        {
            var hashCode = 128850257;
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid?>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime?>.Default.GetHashCode(CreatedOn);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime?>.Default.GetHashCode(ModifiedOn);
            return hashCode;
        }
    }
}
