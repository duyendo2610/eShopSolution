using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Inventorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Inventorys
{
    public class StockMovementConfiguration : IEntityTypeConfiguration<StockMovement>
    {
        public void Configure(EntityTypeBuilder<StockMovement> builder)
        {
            builder.ToTable("stock_movement");
            builder.HasKey(x => x.Id);

            builder
                .HasOne(t => t.ProductVariant)
                .WithMany(t => t.StockMovements)
                .HasForeignKey(t => t.VariantId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
