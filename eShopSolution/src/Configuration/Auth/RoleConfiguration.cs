using eShopSolution.Api.src.Models.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Auth
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("role");
            builder.HasKey(t => t.Id);
            builder.Property(x => x.Name)
               .HasMaxLength(50);

            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
