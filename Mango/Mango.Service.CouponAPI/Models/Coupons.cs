using System.ComponentModel.DataAnnotations;

namespace Mango.Service.CouponAPI.Models
{
    public class Coupons
    {
        [Key]
        public int CouponId { get; set; } =0;
        public string? CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
