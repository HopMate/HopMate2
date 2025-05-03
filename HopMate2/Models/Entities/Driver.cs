using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class Driver
    {
        [Key, ForeignKey(nameof(User))]
        public Guid IdDriver { get; set; }

        public ApplicationUser User { get; set; }

        public required string DrivingLicense { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Reward> Rewards { get; set; } = new List<Reward>();
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}