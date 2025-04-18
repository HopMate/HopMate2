using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class Image
    {
        [Key]
        public Guid IdImage { get; set; } 

        public required string Name { get; set; } 

        public required string FilePath { get; set; } 

        public ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
    }
}