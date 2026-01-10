using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Promotions;

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

        public User User { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public OrderAddress OrderAddress { get; set; }

        public List<OrderStatusHistory> OrderStatusHistories { get; set; }
        public List<Payment> Payments { get; set; }
        public List<Shipment> Shipments { get; set; }

        public CouponUsage  CouponUsage { get; set; }
    }
}
