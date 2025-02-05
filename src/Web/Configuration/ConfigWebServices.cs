using FokinShop.Web.Interfaces;
using FokinShop.Web.Services;

namespace FokinShop.Web.Configuration
{
    public static class ConfigWebServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<IShopViewModelService, ShopViewModelService>();

            return services;
        }
    }
}
