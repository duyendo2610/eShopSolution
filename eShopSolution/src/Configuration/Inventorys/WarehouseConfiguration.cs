using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Inventorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Api.src.Configuration.Inventorys
{
    public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.ToTable("warehouse");
            builder.HasKey(x => x.Id);
        }
    }
}
