using eShopSolution.Api.src.Models.Catalog;

namespace eShopSolution.Api.src.Models.Cart
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int VariantId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPriceSnapshot { get; set; }
        public CartEntity CartEntity { get; set; }
        public ProductVariant ProductVariant { get; set; }
    }
}
