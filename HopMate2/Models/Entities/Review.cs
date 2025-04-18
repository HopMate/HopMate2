using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class Review
    {
        [Key]
        public Guid IdReview { get; set; } 

        public int Rating { get; set; } 

        public required string Comment { get; set; } 

        public DateTime DateReview { get; set; } 

        [ForeignKey(nameof(Driver))]
        public Guid IdDriver { get; set; }
        public Driver Driver { get; set; } 


        [ForeignKey(nameof(Passenger))]
        public Guid IdPassenger { get; set; }
        public Passenger Passenger { get; set; }
    }
}