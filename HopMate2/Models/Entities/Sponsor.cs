using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class Sponsor
    {
        [Key]
        public Guid IdSponsor { get; set; } 

        public required string Name { get; set; } 

        public ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
    }
}