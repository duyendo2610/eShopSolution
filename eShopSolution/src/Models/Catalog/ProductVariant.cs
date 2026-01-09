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
    }
}
