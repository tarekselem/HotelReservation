using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.Entities
{
    public class RoomType : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Rate { get; set; }
        [Required]
        public decimal DepositFeePercentage { get; set; }
        [Required]
        public int CancellationFeeNightsCount { get; set; }
    }
}
