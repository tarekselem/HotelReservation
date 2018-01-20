using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.Entities
{
    public class RoomType : BaseEntity
    {
        public RoomType()
        {
            BookReservations = new HashSet<BookReservation>();
        }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Rate { get; set; }
        [Required]
        public decimal DepositFeePercentage { get; set; }
        [Required]
        public int CancellationFeeNightsCount { get; set; }

        public virtual ICollection<BookReservation> BookReservations { get; set; }
    }
}
