using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Cart;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Carts
{
    public class CartEntityConfiguration : IEntityTypeConfiguration<CartEntity>
    {
        public void Configure(EntityTypeBuilder<CartEntity> builder)
        {
            builder.ToTable("cart");
            builder.HasKey(t => t.Id);


            builder
                .HasOne(t => t.User)
                .WithOne(t => t.CartEntity)
                .HasForeignKey<CartEntity>(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
