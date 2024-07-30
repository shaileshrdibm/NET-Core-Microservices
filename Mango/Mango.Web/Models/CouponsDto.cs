using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Mango.Web.Models
{
    public class CouponsDTO
    {
        public int CouponId { get; set; }
        public string? CouponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
