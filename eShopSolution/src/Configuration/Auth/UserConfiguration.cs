using eShopSolution.Api.src.Models.Auth;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.Api.src.Configuration.Auth
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.Id);
        }
    }
}

 