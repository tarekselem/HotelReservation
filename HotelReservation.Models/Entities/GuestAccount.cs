using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.Entities
{
    public class GuestAccount:BaseEntity
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [DefaultValue(0)]
        public decimal RemainingAmount { get; set; }
    }
}
