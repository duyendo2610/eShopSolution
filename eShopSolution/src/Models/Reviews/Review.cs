using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Catalog;
using eShopSolution.Api.src.Models.Orders;

namespace eShopSolution.Api.src.Models.Reviews
{
    public class Review
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int OrderItemId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
        public OrderItem OrderItem { get; set; }
    }
}
