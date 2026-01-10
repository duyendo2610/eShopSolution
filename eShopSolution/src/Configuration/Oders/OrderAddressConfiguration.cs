using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Oders
{
    public class OrderAddressConfiguration : IEntityTypeConfiguration<OrderAddress>

    {
        public void Configure(EntityTypeBuilder<OrderAddress> builder)
        {
            builder.ToTable("order_address");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.Order)
                .WithOne(t => t.OrderAddress)
                .HasForeignKey<OrderAddress>(t => t.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
