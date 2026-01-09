namespace eShopSolution.Api.src.Models.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public decimal Subtotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
