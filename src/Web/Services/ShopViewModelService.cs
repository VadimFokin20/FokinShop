using FokinShop.ApplicationCore.Interfaces;
using FokinShop.Web.Models;
using FokinShop.Web.Interfaces;
using FokinShop.Web.ConstantValues;
using FokinShop.ApplicationCore.Specifications;
using FokinShop.ApplicationCore.Entities;
using Ardalis.Specification;

namespace FokinShop.Web.Services
{
    public class ShopViewModelService : IShopViewModelService
    {
        private readonly ILogger<ShopViewModelService> _logger;
        private readonly IRepositoryBase<CatalogItem> _catalogRepo;
        private readonly IRepositoryBase<CatalogBrand> _brandRepo;
        private readonly IRepositoryBase<CatalogType> _typeRepo;
        private readonly IRepositoryBase<ProductSize> _sizeRepo;
        private readonly IUriComposer _uriComposer;

        public ShopViewModelService(ILogger<ShopViewModelService> logger,
                                    IRepositoryBase<CatalogItem> catalogRepo,
                                    IRepositoryBase<CatalogBrand> brandRepo,
                                    IRepositoryBase<CatalogType> typeRepo,
                                    IRepositoryBase<ProductSize> sizeRepo,
                                    IUriComposer uriComposer)
        {
            _logger = logger;
            _catalogRepo = catalogRepo;
            _brandRepo = brandRepo;
            _typeRepo = typeRepo;
            _sizeRepo = sizeRepo;
            _uriComposer = uriComposer;
        }

        public async Task<ShopViewModel> GetShopViewModel(int pageIndex, int? brandId, int? typeId, int? sizeId)
        {
            _logger.LogInformation("Creating shop view");

            var catalogFilterSpec = new CatalogFilterSpec(brandId, typeId, sizeId);
            var totalPages = ((await _catalogRepo.CountAsync(catalogFilterSpec) - 1) / Constants.ITEMS_PER_PAGE) + 1;
            pageIndex = pageIndex > totalPages ? totalPages : pageIndex;

            var catalogFilterPaginatedSpec = new CatalogFilterPaginatedSpec(
                    (pageIndex - 1) * Constants.ITEMS_PER_PAGE, 
                    Constants.ITEMS_PER_PAGE,
                    brandId,
                    typeId,
                    sizeId
                );
            var catalogItems = await _catalogRepo.ListAsync(catalogFilterPaginatedSpec);

            var svm = new ShopViewModel()
            {
                CatalogItems = catalogItems.Select(c => new CatalogItemViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    PictureUri = _uriComposer.ComposeImageUri(c.PictureUri),
                    Rating = c.Rating,
                    ProductSizes = c.ProductSizes,
                    Price = c.Price,
                }).ToList(),
                Brands = await GetBrands(),
                Types = await GetTypes(),
                Sizes = await GetSizes(),
                BrandFilterApplied = brandId,
                TypeFilterApplied = typeId,
                SizeFilterApplied = sizeId,
                
                Pagination = new PaginationViewModel()
                {
                    TotalPages = totalPages,
                    CurrentPage = pageIndex,
                    Previous = pageIndex > 1 ? (pageIndex - 1) : null,
                    Next = pageIndex < totalPages ? (pageIndex + 1) : null
                }
            };

            return svm;
        }

        public async Task<List<CatalogBrand>> GetBrands()
        {
            var brands = await _brandRepo.ListAsync();

            var resBrands = brands.OrderBy(b => b.Brand).ToList();
            resBrands.Insert(0, new CatalogBrand(0, "All"));
            
            return resBrands;
        }

        public async Task<List<CatalogType>> GetTypes()
        {
            var types = await _typeRepo.ListAsync();

            var resTypes = types.OrderBy(t => t.Type).ToList();
            resTypes.Insert(0, new CatalogType(0, "All"));

            return resTypes;
        }

        public async Task<List<ProductSize>> GetSizes()
        {
            var sizes = await _sizeRepo.ListAsync();

            var resSizes = sizes.ToList();

            return resSizes;
        }
    }
}
