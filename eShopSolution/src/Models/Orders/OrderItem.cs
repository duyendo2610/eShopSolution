using eShopSolution.Api.src.Models.Catalog;
using eShopSolution.Api.src.Models.Reviews;

namespace eShopSolution.Api.src.Models.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int VariantId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPriceSnapshot { get; set; }
        public decimal LineTotal { get; set; }

        public Order Order { get; set; }
        public ProductVariant ProductVariant { get; set; }
        public Review Review { get; set; }
    }
}
