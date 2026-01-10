using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Oders
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("orders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.OrderCode)
                   .HasMaxLength(50);

            builder.Property(x => x.Status)
                   .HasMaxLength(30);

            builder.Property(x => x.PaymentStatus)
                   .HasMaxLength(30);

            builder.Property(x => x.Subtotal).HasPrecision(18, 2);
            builder.Property(x => x.DiscountAmount).HasPrecision(18, 2);
            builder.Property(x => x.ShippingFee).HasPrecision(18, 2);
            builder.Property(x => x.TotalAmount).HasPrecision(18, 2);

            builder.HasIndex(x => x.OrderCode).IsUnique();
            builder.HasIndex(x => new { x.UserId, x.CreatedAt });

            builder
                .HasOne(t => t.User)
                .WithMany(t => t.Orders)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
