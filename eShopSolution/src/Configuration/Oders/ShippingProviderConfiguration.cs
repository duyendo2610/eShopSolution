using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Oders
{
    public class ShippingProviderConfiguration : IEntityTypeConfiguration<ShippingProvider>
    {
        public void Configure(EntityTypeBuilder<ShippingProvider> builder)
        {
            builder.ToTable("shipping_provider");
            builder.HasKey(t => t.Id);
        }
    }
}
