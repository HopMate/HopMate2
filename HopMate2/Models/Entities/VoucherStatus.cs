using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class VoucherStatus
    {
        [Key]
        public Guid IdVoucherStatus { get; set; }

        public required string Status { get; set; } 

        public ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
    }
}