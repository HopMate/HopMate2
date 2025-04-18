using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HopMate2.Models.Entities
{
    public class MemberVoucher
    {
        [Key]
        public Guid IdMemberVoucher { get; set; } 

        public DateTime DateRedeemed { get; set; } 

        [ForeignKey(nameof(ApplicationUser))]
        public Guid IdMember { get; set; } 
        public ApplicationUser Member { get; set; } 


        [ForeignKey(nameof(Voucher))]
        public Guid IdVoucher { get; set; }
        public Voucher Voucher { get; set; } 
    }
}