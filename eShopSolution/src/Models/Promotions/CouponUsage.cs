using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Orders;

namespace eShopSolution.Api.src.Models.Promotions
{
    public class CouponUsage
    {
        public int Id { get; set; }
        public int CouponId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public DateTime UsedAt { get; set; }

        public Coupon Coupon { get; set; }
        public User User { get; set; }
        public Order Order { get; set; }

    }
}
