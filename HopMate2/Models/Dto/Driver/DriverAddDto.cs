namespace HopMate2.Models.Dto.Driver
{
    public class DriverAddDto
    {
        public Guid IdDriver { get; set; }
        public required string DrivingLicense { get; set; }
    }
}
