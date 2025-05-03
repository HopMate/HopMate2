using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace HopMate2.Models.Dto.User
{
    public class User
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
