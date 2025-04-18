using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class Passenger
    {
        [Key, ForeignKey(nameof(User))]
        public Guid IdUser { get; set; }

        public ApplicationUser User { get; set; }

        public ICollection<PassengerTrip> PassengerTrips { get; set; } = new List<PassengerTrip>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
