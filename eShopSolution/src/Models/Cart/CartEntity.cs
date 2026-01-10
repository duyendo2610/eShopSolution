using eShopSolution.Api.src.Models.Auth;

namespace eShopSolution.Api.src.Models.Cart
{
    public class CartEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
