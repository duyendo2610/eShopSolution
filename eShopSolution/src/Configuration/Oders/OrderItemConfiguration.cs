using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Oders
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("order_item");
            builder.HasKey(x => x.Id);

            builder
                .HasOne(t => t.Order)
                .WithMany(t => t.OrderItems)
                .HasForeignKey(t => t.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(t => t.ProductVariant)
                .WithMany(t => t.OrderItems)
                .HasForeignKey(t => t.VariantId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
