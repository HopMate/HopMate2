using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class Location
    {
        [Key]
        public Guid IdLocation { get; set; }
        public required string Address { get; set; }
        public required string PC1 { get; set; }
        public required string PC2 { get; set; }

        public ICollection<TripLocation> TripLocations { get; set; } = new List<TripLocation>();
    }
}
