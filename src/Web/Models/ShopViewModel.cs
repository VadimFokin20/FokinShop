using FokinShop.ApplicationCore.Entities;

namespace FokinShop.Web.Models
{
    public class ShopViewModel
    {
        public List<CatalogItemViewModel> CatalogItems { get; set; } = new();
        public List<CatalogBrand> Brands { get; set; } = new();
        public List<CatalogType> Types { get; set; } = new();
        public List<ProductSize> Sizes { get; set; } = new();
        public int? BrandFilterApplied { get; set; }
        public int? TypeFilterApplied { get; set; }
        public int? SizeFilterApplied { get; set; }
        public PaginationViewModel? Pagination { get; set; }
    }
}
