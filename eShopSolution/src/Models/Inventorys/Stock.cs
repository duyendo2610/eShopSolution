using eShopSolution.Api.src.Models.Catalog;

namespace eShopSolution.Api.src.Models.Inventorys
{
    public class Stock
    {
        public int Id { get; set; }
        public int VariantId { get; set; }
        public int WarehouseId { get; set; }
        public int Quantity { get; set; }
        public int ReservedQuantity { get; set; }

        public ProductVariant ProductVariant { get; set; }
        public Warehouse Warehouse { get; set; }

    }
}
