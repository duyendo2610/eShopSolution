using eShopSolution.Api.src.Models.Cart;
using eShopSolution.Api.src.Models.Inventorys;
using eShopSolution.Api.src.Models.Orders;

namespace eShopSolution.Api.src.Models.Catalog
{
    public class ProductVariant
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public decimal? CompareAtPrice { get; set; }
        public bool IsActive { get; set; }

        public List<CartItem> CartItems { get; set; }
        public Product Product { get; set; }

        public List<VariantOption> VariantOption { get; set; }
        public List<Stock> Stocks { get; set; }
        public List<StockMovement> StockMovements { get; set; }
        public List<OrderItem> OrderItems { get; set; }


    }
}
