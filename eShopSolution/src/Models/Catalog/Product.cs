using eShopSolution.Api.src.Models.Reviews;

namespace eShopSolution.Api.src.Models.Catalog
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }    
        public int BrandId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public Category Category { get; set; }

        public Brand Brand { get; set; }

        public List<ProductVariant> ProductVariants { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
