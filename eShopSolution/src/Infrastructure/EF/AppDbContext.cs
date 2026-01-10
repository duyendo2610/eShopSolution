using eShopSolution.Api.src.Configuration.Auth;
using eShopSolution.Api.src.Configuration.Cart;
using eShopSolution.Api.src.Configuration.Carts;
using eShopSolution.Api.src.Configuration.Catalog;
using eShopSolution.Api.src.Configuration.Inventorys;
using eShopSolution.Api.src.Configuration.Oders;
using eShopSolution.Api.src.Configuration.Promotions;
using eShopSolution.Api.src.Configuration.Reviews;
using eShopSolution.Api.src.Models.Auth;
using eShopSolution.Api.src.Models.Cart;
using eShopSolution.Api.src.Models.Catalog;
using eShopSolution.Api.src.Models.Inventorys;
using eShopSolution.Api.src.Models.Orders;
using eShopSolution.Api.src.Models.Promotions;
using eShopSolution.Api.src.Models.Reviews;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.Api.src.Infrastructure.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RefreshTokenConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new CartEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CartItemConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductVariantConfiguration());
            modelBuilder.ApplyConfiguration(new VariantOptionConfiguration());
            modelBuilder.ApplyConfiguration(new StockConfiguration());
            modelBuilder.ApplyConfiguration(new StockMovementConfiguration());
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderAddressConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new ShipmentConfiguration());
            modelBuilder.ApplyConfiguration(new ShippingProviderConfiguration());
            modelBuilder.ApplyConfiguration(new CouponConfiguration());
            modelBuilder.ApplyConfiguration(new CouponUsageConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
        }

        public DbSet<User> Users {  get; set; }
        public DbSet<Role> Roles {  get; set; }
        public DbSet<RefreshToken> RefreshTokens {  get; set; }
        public DbSet<Category> Categorys {  get; set; }
        public DbSet<Brand> Brands {  get; set; }
        public DbSet<Product> Products {  get; set; }
        public DbSet<ProductVariant> ProductVariants {  get; set; }
        public DbSet<VariantOption> VariantOptions {  get; set; }
        public DbSet<ProductImage> ProductImages {  get; set; }
        public DbSet<Warehouse> Warehouses {  get; set; }
        public DbSet<Stock> Stocks {  get; set; }
        public DbSet<StockMovement> StockMovements {  get; set; }
        public DbSet<CartEntity> Carts {  get; set; }
        public DbSet<CartItem> CartItems {  get; set; }
        public DbSet<Order> Orders {  get; set; }
        public DbSet<OrderItem> OrderItems {  get; set; }
        public DbSet<OrderAddress> OrderAddresss {  get; set; }
        public DbSet<OrderStatusHistory> OrderStatusHistorys {  get; set; }
        public DbSet<Payment> Payments {  get; set; }
        public DbSet<Shipment> Shipments {  get; set; }
        public DbSet<ShippingProvider> ShippingProviders {  get; set; }
        public DbSet<Coupon> Coupons {  get; set; }
        public DbSet<CouponUsage> CouponUsages {  get; set; }
        public DbSet<Review> Reviews {  get; set; }

        
    }
}
