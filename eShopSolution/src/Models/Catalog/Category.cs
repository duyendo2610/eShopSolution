namespace eShopSolution.Api.src.Models.Catalog
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int? ParentId { get; set; }
        public bool IsActive { get; set; }

        public Category? Parent { get; set; }
        public List<Category> Children { get; set; }

        public List<Product> Products { get; set; }
    }
}
