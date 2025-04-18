using System.ComponentModel.DataAnnotations;

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

        public Guid IdVehicle { get; set; }
        public Vehicle Vehicle { get; set; }

        public Guid IdStatusTrip { get; set; }
        public StatusTrip StatusTrip { get; set; }

        public ICollection<PassengerTrip> PassengerTrips { get; set; } = new List<PassengerTrip>();
        public ICollection<TripLocation> TripLocations { get; set; } = new List<TripLocation>();
    }
}
