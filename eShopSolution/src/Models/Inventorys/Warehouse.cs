namespace eShopSolution.Api.src.Models.Inventorys
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Stock> Stocks { get; set; }
    }
}
