using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class Voucher
    {
        [Key]
        public Guid IdVoucher { get; set; }

        public required string Name { get; set; }

        public int HopsCost { get; set; }

        public DateTime ExpiracyDate { get; set; }

        [ForeignKey(nameof(Sponsor))]
        public Guid IdSponsor { get; set; }
        public Sponsor Sponsor { get; set; }

        [ForeignKey(nameof(VoucherStatus))]
        public Guid IdVoucherStatus { get; set; }
        public VoucherStatus VoucherStatus { get; set; }

        [ForeignKey(nameof(Image))]
        public Guid IdImage { get; set; }
        public Image Image { get; set; }

        public ICollection<MemberVoucher> MemberVouchers { get; set; } = new List<MemberVoucher>();
    }
}
