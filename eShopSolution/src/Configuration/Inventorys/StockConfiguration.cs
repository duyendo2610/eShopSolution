using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Inventorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Inventorys
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.ToTable("stock");
            builder.HasKey(x => x.Id);

            builder
                .HasOne(t => t.ProductVariant)
                .WithMany(t => t.Stocks)
                .HasForeignKey(t => t.VariantId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(t => t.Warehouse)
                .WithMany(t => t.Stocks)
                .HasForeignKey(t => t.WarehouseId)
                .OnDelete(DeleteBehavior.Cascade);  


        }
    }
}
