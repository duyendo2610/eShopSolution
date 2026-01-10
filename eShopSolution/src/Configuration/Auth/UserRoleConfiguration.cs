using eShopSolution.Api.src.Models.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Auth
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("user_role");
            builder.HasIndex(x => x.UserRoleId);

            builder.HasKey(t => new { t.RoleId, t.UserId });

            builder.HasOne(t => t.User)
                .WithMany(t => t.UserRole)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade); ;

            builder.HasOne(t => t.Role)
                .WithMany(t => t.UserRole)
                .HasForeignKey(t => t.RoleId)
                .OnDelete(DeleteBehavior.Cascade); ;
        }
    }
}
