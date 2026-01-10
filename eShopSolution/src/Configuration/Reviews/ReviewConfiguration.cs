using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Reviews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Reviews
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("reviews");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Comment)
                   .HasMaxLength(1000);

            builder.HasIndex(x => new { x.UserId, x.ProductId });
            builder.HasIndex(x => x.OrderItemId).IsUnique();


            builder.HasOne(x => x.Product)
             .WithMany(p => p.Reviews)
             .HasForeignKey(x => x.ProductId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.User)
             .WithMany(u => u.Reviews)
             .HasForeignKey(x => x.UserId)
             .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.OrderItem)
             .WithOne(t => t.Review)
             .HasForeignKey<Review>(x => x.OrderItemId)
             .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
