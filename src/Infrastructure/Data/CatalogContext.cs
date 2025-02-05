using FokinShop.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace FokinShop.Infrastructure.Data
{
    public class CatalogContext : DbContext
    {
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }

        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options) 
        { 
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CatalogBrand>().HasData(SeedCatalogContext.GetCatalogBrands());
            modelBuilder.Entity<CatalogType>().HasData(SeedCatalogContext.GetCatalogTypes());

            modelBuilder.Entity<CatalogItem>().HasData(SeedCatalogContext.GetCatalogItems());
            modelBuilder.Entity<ProductSize>(ps =>
            {
                ps.HasData(SeedCatalogContext.GetProductSizes());
                ps.HasMany(x => x.CatalogItems)
                    .WithMany(x => x.ProductSizes)
                    .UsingEntity(
                            "CatalogItemProductSize",
                            l => l.HasOne(typeof(CatalogItem)).WithMany().HasForeignKey("CatalogItemId").HasPrincipalKey(nameof(CatalogItem.Id)),
                            r => r.HasOne(typeof(ProductSize)).WithMany().HasForeignKey("ProductSizeId").HasPrincipalKey(nameof(ProductSize.Id)),
                            je =>
                            {
                                je.HasKey("CatalogItemId", "ProductSizeId");
                                je.HasData(SeedCatalogContext.GetCatalogItemProductSize());
                            }
                        );
            });
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<decimal>().HavePrecision(18, 2);
        }
    }
}
