using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Key]
        public Guid IdMember { get; set; }
        public required string Name { get; set; }
        public int Points { get; set; }
        public int TotalPoints { get; set; }
        public int Hops { get; set; }
        public DateOnly DtBirth { get; set; }
        public string? ImageFilePath { get; set; }

        public ICollection<Penalty> Penalties { get; set; } = new List<Penalty>();
        public ICollection<MemberVoucher> MemberVouchers { get; set; } = new List<MemberVoucher>();
    }
}
