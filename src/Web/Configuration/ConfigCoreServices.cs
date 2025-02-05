using Ardalis.Specification;
using FokinShop.ApplicationCore.Config;
using FokinShop.ApplicationCore.Interfaces;
using FokinShop.ApplicationCore.Services;
using FokinShop.Infrastructure.Data;

namespace FokinShop.Web.Configuration
{
    public static class ConfigCoreServices
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(CatalogRepository<>));

            var imageSourceConfig = configuration.Get<ImageSourceConfig>() ?? new(); 
            services.AddSingleton<IUriComposer>(new UriComposer(imageSourceConfig));

            return services;
        }
    }
}
