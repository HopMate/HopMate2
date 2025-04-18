using System.ComponentModel.DataAnnotations;
namespace HopMate2.Models.Entities
{
    public class StatusTrip
    {
        [Key]
        public Guid IdStatusTrip { get; set; }
        public required string Status { get; set; }
        public ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}