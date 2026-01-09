namespace eShopSolution.Api.src.Models.Catalog
{
    public class VariantOption
    {
        public int Id { get; set; }
        public int VariantId { get; set; }
        public string OptionName { get; set; }   
        public string OptionValue { get; set; } 
    }
}
