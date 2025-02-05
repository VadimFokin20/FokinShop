using FokinShop.ApplicationCore.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FokinShop.Infrastructure.Identity
{
    public class ShopUserContext : IdentityDbContext<ShopUser>
    {
        public ShopUserContext(DbContextOptions<ShopUserContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
