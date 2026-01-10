using eShopSolution.Api.src.Models.Orders;
using eShopSolution.Api.src.Models.Promotions;
using eShopSolution.Api.src.Models.Reviews;
using CartEntity = eShopSolution.Api.src.Models.Cart.CartEntity;
namespace eShopSolution.Api.src.Models.Auth
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public List<RefreshToken> RefreshTokens { get; set; }

        public List<UserRole> UserRole { get; set; }
        public CartEntity CartEntity { get; set; }
        public List<Order> Orders { get; set; }

        public List<CouponUsage> CouponUsages { get; set; }
        public List<Review> Reviews { get; set; }

    }
}
