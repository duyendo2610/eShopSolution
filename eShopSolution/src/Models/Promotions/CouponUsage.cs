namespace eShopSolution.Api.src.Models.Promotions
{
    public class CouponUsage
    {
        int Id { get; set; }
        int CouponId { get; set; }
        int UserId { get; set; }
        int OrderId { get; set; }
        DateTime UsedAt { get; set; }
    }
}
