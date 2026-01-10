using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Oders
{
    public class ShipmentConfiguration : IEntityTypeConfiguration<Shipment>
    {
        public void Configure(EntityTypeBuilder<Shipment> builder)
        {
            builder.ToTable("shipment");
            builder.HasKey(x => x.Id);

            builder
                .HasOne(t => t.Order)
                .WithMany(t => t.Shipments)
                .HasForeignKey(t => t.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(t => t.ShippingProvider)
                .WithMany(t => t.Shipments)
                .HasForeignKey(t => t.ShippingProviderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
