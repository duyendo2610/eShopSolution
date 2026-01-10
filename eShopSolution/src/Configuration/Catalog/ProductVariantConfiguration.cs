using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Catalog
{
    public class ProductVariantConfiguration : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(EntityTypeBuilder<ProductVariant> builder)
        {
            builder.ToTable("product_variants");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.SKU)
                   .HasMaxLength(100);

            builder.Property(x => x.Price)
                   .HasPrecision(18, 2);

            builder.Property(x => x.CompareAtPrice)
                   .HasPrecision(18, 2);

            builder.HasIndex(x => x.SKU).IsUnique();
            builder.HasIndex(x => new { x.ProductId, x.IsActive });

            builder
                .HasOne(t => t.Product)
                .WithMany(t => t.ProductVariants)
                .HasForeignKey(t => t.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
