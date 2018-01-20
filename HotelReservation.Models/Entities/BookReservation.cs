using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservation.Models.Entities
{
    public class BookReservation:BaseEntity
    {
        [Required]
        public int RoomTypeId { get; set; }
        [Required]
        public string RoomeNumber { get; set; }
        [Required,DefaultValue(0)]
        public decimal DepositeFeeAmount { get; set; }
        [Required, DefaultValue(0)]
        public decimal CancellationFeeAmount { get; set; }
        [Required]
        public int GuestAccountId { get; set; }
        [Required]
        public DateTime ArrivalDate { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        [DefaultValue(false)]
        public bool IsCheckedIn { get; set; }
        [DefaultValue(false)]
        public bool IsCheckedOut { get; set; }
        [DefaultValue(false)]
        public bool IsDepositePaid { get; set; }
        [DefaultValue(false)]
        public bool IsCanceled { get; set; }

        [ForeignKey("RoomTypeId")]
        public virtual RoomType RoomType { get; set; }
        [ForeignKey("GuestAccountId")]
        public virtual GuestAccount GuestAccount { get; set; }
    }
}
