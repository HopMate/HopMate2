using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class Reward
    {
        [Key]
        public Guid IdReward { get; set; } 

        public int Hops { get; set; } 

        public int Points { get; set; } 

        public string Reason { get; set; } 

        public DateTime Date { get; set; } 

        [ForeignKey(nameof(Driver))]
        public Guid IdDriver { get; set; } 
        public Driver Driver { get; set; } 
    }
}