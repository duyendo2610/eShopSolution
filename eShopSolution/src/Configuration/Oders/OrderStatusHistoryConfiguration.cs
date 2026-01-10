using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Oders
{
    public class OrderStatusHistoryConfiguration : IEntityTypeConfiguration<OrderStatusHistory>
    {
        public void Configure(EntityTypeBuilder<OrderStatusHistory> builder)
        {
            builder.ToTable("order_status_history");
            builder.HasKey(x => x.Id);

            builder
                .HasOne(t => t.Order)
                .WithMany(t => t.OrderStatusHistories)
                .HasForeignKey(t => t.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
