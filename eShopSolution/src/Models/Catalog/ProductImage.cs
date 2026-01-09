namespace eShopSolution.Api.src.Models.Catalog
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int? VariantId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }
        public int SortOrder { get; set; }
    }
}

