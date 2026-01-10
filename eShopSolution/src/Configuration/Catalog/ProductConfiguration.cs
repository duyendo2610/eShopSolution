using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Catalog
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                   .HasMaxLength(250);

            builder.Property(x => x.Slug)
                   .HasMaxLength(250);

            builder.Property(x => x.Description)
                   .HasMaxLength(4000);

            builder.HasIndex(x => x.Slug).IsUnique();
            builder.HasIndex(x => new { x.CategoryId, x.IsActive });
            builder.HasIndex(x => new { x.BrandId, x.IsActive });

            builder
                .HasOne(t => t.Category)
                .WithMany(t => t.Products)
                .HasForeignKey(t => t.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(t => t.Brand)
                .WithMany(t => t.Products)
                .HasForeignKey(t =>t.BrandId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

