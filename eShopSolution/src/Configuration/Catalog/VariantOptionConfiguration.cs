using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Catalog
{
    public class VariantOptionConfiguration : IEntityTypeConfiguration<VariantOption>
    {
        public void Configure(EntityTypeBuilder<VariantOption> builder)
        {
            builder.ToTable("variant_option");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.productVariant)
                .WithMany(t => t.VariantOption)
                .HasForeignKey(t => t.VariantId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
