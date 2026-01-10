namespace eShopSolution.Api.src.Models.Orders
{
    public class ShippingProvider
    {
        public int Id { get; }
        public string Name { get; set; }

        public List<Shipment> Shipments { get; set; }
    }
}
