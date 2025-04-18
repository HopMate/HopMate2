using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class TripLocation
    {
        [Key]
        public Guid IdTripLocation { get; set; }

        public Guid IdTrip { get; set; }
        public Trip Trip { get; set; }

        public Guid IdLocation { get; set; }
        public Location Location { get; set; }

        public bool IsStart { get; set; }  // true para partida, false para chegada
    }
}
