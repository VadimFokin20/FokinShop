using FokinShop.ApplicationCore.Entities;
using FokinShop.Web.Models;

namespace FokinShop.Web.Interfaces
{
    public interface IShopViewModelService
    {
        Task<ShopViewModel> GetShopViewModel(int pageIndex, int? brandId, int? typeId, int? sizeId); 
        Task<List<CatalogBrand>> GetBrands();
        Task<List<CatalogType>> GetTypes();
    }
}
