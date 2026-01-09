namespace eShopSolution.Api.src.Models.Orders
{
    public class OrderStatusHistory
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string FromStatus { get; set; }
        public string ToStatus { get; set; }
        public string Note { get; set; }
        public int? ChangedByUserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
