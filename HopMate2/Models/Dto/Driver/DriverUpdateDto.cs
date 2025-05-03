using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Dto.Driver
{
    public class DriverUpdateDto
    {
        public required string DrivingLicense { get; set; }
    }
}
