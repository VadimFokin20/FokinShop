using FokinShop.Infrastructure.Data;
using FokinShop.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FokinShop.Infrastructure.Config
{
    public static class ConfigDb
    {
        public static void ConfigureDbServices(this IServiceCollection services, IConfiguration configuration)
        {
            string? catalogConnection = configuration.GetConnectionString("CatalogDb");
            services.AddDbContext<CatalogContext>(options =>
            {
                options.UseSqlServer(catalogConnection);
            });

            string? shopUserConnection = configuration.GetConnectionString("ShopUserDb");
            services.AddDbContext<ShopUserContext>(options =>
            {
                options.UseSqlServer(shopUserConnection);
            });
        }
    }
}
