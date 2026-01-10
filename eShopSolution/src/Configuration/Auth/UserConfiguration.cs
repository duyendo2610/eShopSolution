using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Cart;
using Microsoft.EntityFrameworkCore;


namespace eShopSolution.Api.src.Configuration.Auth
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");
            builder.HasKey(t => t.Id);
            builder.Property(x => x.Email)
              .HasMaxLength(256);

            builder.Property(x => x.PasswordHash)
                   .HasMaxLength(500);

            builder.Property(x => x.FullName)
                   .HasMaxLength(200);

            builder.Property(x => x.Phone)
                   .HasMaxLength(20);

            builder.HasIndex(x => x.Email).IsUnique();

        }
    }
}

