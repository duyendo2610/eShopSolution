namespace eShopSolution.Api.src.Models.Orders
{
    public class Shipment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ShippingProviderId { get; set; }
        public string Status { get; set; }
        public string TrackingCode { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
