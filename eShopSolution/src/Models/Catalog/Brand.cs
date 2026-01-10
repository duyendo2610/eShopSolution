namespace eShopSolution.Api.src.Models.Catalog
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public List<Product> Products { get; set; }
    }
}

