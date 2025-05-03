namespace HopMate2.Models.Dto.PassengerTrip
{
    public class PassengerTripAddDto
    {
        public Guid IdPassenger { get; set; }
        public Guid IdTrip { get; set; }
        public Guid IdLocation { get; set; }
        public int IdRequestStatus { get; set; }
        public DateTime DateRequest { get; set; }
        public required string Reason { get; set; }
    }
}
