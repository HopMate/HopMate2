using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Dto.User
{
    public class AuthenticationRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
