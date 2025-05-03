using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HopMate2.Models.Entities
{
    public class Trip
    {
        [Key]
        public Guid IdTrip { get; set; } 

        public DateTime DateDeparture { get; set; } 
        public DateTime DateArrival { get; set; } 
        public int AvailableSeats { get; set; }

        
        public Guid IdDriver { get; set; }
        public Driver Driver { get; set; }

        [ForeignKey(nameof(Vehicle))]
        public Guid IdVehicle { get; set; }
        public Vehicle Vehicle { get; set; }

        [ForeignKey(nameof(StatusTrip))]
        public Guid IdStatusTrip { get; set; }
        public StatusTrip StatusTrip { get; set; }

        public ICollection<PassengerTrip> PassengerTrips { get; set; } = new List<PassengerTrip>();
        public ICollection<TripLocation> TripLocations { get; set; } = new List<TripLocation>();
    }
}
