using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class Vehicle
    {
        [Key]
        public Guid IdVehicle { get; set; } 
        public required string Brand { get; set; } 
        public required string Model { get; set; } 
        public required string Color { get; set; } 
        public required string Plate { get; set; } 
        public int Seats { get; set; } 
        public required string ImageFilePath { get; set; } 

        [ForeignKey(nameof(Driver))]
        public Guid IdDriver { get; set; }
        public Driver Driver { get; set; }

        public ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}