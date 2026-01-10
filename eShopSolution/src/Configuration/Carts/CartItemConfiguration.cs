using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Cart;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Emit;

namespace eShopSolution.Api.src.Configuration.Cart
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.ToTable("cart_items");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.UnitPriceSnapshot)
                   .HasPrecision(18, 2);

            builder.HasIndex(x => new { x.CartId, x.VariantId }).IsUnique();

            builder
                .HasOne(t => t.CartEntity)
                .WithMany(t => t.CartItems)
                .HasForeignKey(t => t.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.ProductVariant)
                .WithMany(t => t.CartItems)
                .HasForeignKey(t => t.VariantId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(t => t.Id);
        }
    }
}
