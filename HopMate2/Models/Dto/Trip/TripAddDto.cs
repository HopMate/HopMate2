namespace HopMate2.Models.Dto.Trip
{
    public class TripAddDto
    {
        public DateTime DateDeparture { get; set; }
        public DateTime DateArrival { get; set; }
        public int AvailableSeats { get; set; }

        public Guid IdDriver { get; set; }
        public Guid IdVehicle { get; set; }
        public Guid IdStatusTrip { get; set; }
    }
}
