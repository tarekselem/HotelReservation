using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelReservation.Models.Entities
{
    public class BookReservation:BaseEntity
    {
        [Required]
        public Guid RoomTypeId { get; set; }
        [Required]
        public string RoomeNumber { get; set; }
        [Required,DefaultValue(0)]
        public decimal DepositeFeeAmount { get; set; }
        [Required, DefaultValue(0)]
        public decimal CancellationFeeAmount { get; set; }
        [Required]
        public Guid GuestAccountId { get; set; }
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
    }
}
