using eShopSolution.Api.src.Models.Catalog;

namespace eShopSolution.Api.src.Models.Inventorys
{
    public class StockMovement
    {
        public int Id { get; set; }
        public int VariantId { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public string ReferenceType { get; set; }
        public int? ReferenceId { get; set; }
        public DateTime CreatedAt { get; set; }
        public ProductVariant ProductVariant { get; set; }
    }
}
