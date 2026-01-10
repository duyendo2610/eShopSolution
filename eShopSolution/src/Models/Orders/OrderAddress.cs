namespace eShopSolution.Api.src.Models.Orders
{
    public class OrderAddress
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ReceiverName { get; set; }
        public string Phone { get; set; }
        public string AddressLine { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string Province { get; set; }

        public Order Order { get; set; }
    }
}
