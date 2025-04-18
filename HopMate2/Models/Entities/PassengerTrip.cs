using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class PassengerTrip
    {
        [Key]
        public Guid IdPassengerTrip { get; set; }
        public Guid IdPassenger { get; set; }
        [ForeignKey("IdPassenger")]
        public Passenger Passenger { get; set; }
        public Guid IdTrip { get; set; }
        [ForeignKey("IdTrip")]
        public Trip Trip { get; set; }
        public Guid IdLocation { get; set; }
        [ForeignKey("IdLocation")]
        public Location Location { get; set; }
        public int IdRequestStatus { get; set; }
        [ForeignKey("IdRequestStatus")]
        public RequestStatus RequestStatus { get; set; }
        public DateTime DateRequest { get; set; }
        public required string Reason { get; set; }       
    }
}
