namespace HopMate2.Models.Dto.TripLocation
{
    public class TripLocationAddDto
    {
        public Guid IdTrip { get; set; }
        public Guid IdLocation { get; set; }
        public bool IsStar { get; set; }
    }
}
