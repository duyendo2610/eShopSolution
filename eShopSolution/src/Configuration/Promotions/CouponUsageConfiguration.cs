using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Promotions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Promotions
{
    public class CouponUsageConfiguration : IEntityTypeConfiguration<CouponUsage>
    {
        public void Configure(EntityTypeBuilder<CouponUsage> builder)
        {
            builder.ToTable("coupon_usage");
            builder.HasKey(t => t.Id);

            builder
                .HasOne(t => t.Coupon)
                .WithMany(t => t.CouponUsages)
                .HasForeignKey(t => t.CouponId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(t => t.User)
                .WithMany(t => t.CouponUsages)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder
                .HasOne(t => t.Order)
                .WithOne(t => t.CouponUsage)
                .HasForeignKey<CouponUsage>(t => t.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
