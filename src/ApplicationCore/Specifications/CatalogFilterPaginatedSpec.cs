using Ardalis.Specification;
using FokinShop.ApplicationCore.Entities;

namespace FokinShop.ApplicationCore.Specifications
{
    public class CatalogFilterPaginatedSpec : Specification<CatalogItem>
    {
        public CatalogFilterPaginatedSpec(int skip, int take, int? brandId, int? typeId, int? sizeId) 
        { 
            if (brandId == 0) brandId = null;
            if (typeId == 0) typeId = null;
            if (sizeId == 0) sizeId = null;

            Query
                .Include(c => c.ProductSizes)
                .Include(c => c.CatalogBrand)
                .Include(c => c.CatalogType)
                .Where(c => (!brandId.HasValue || c.CatalogBrandId == brandId) &&
                            (!typeId.HasValue || c.CatalogTypeId == typeId) &&
                            (!sizeId.HasValue || c.ProductSizes.Any(s => s.Id == sizeId)))
                .Skip(skip)
                .Take(take);
        }
    }
}
