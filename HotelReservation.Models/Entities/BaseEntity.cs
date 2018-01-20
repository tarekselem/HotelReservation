using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public DateTime ModifiedOn { get; set; }
    }
}
