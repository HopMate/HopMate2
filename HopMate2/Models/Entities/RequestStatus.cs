using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class RequestStatus
    {
        [Key]
        public int IdRequestStatus { get; set; }
        public required string Status { get; set; }
        public ICollection<PassengerTrip> PassengerTrips { get; set; } = new List<PassengerTrip>();
    }
}