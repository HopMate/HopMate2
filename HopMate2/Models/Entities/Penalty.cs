using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class Penalty
    {
        [Key]
        public Guid IdPenalty { get; set; } 

        public int Hops { get; set; } 

        public int Points { get; set; } 

        [ForeignKey(nameof(ApplicationUser))]
        public Guid IdMember { get; set; } 
        public ApplicationUser Member { get; set; } 
    }
}