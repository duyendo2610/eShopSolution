

using Microsoft.EntityFrameworkCore;

namespace eShopSolution.Api.src.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
    }
}
