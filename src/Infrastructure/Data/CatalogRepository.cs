using Ardalis.Specification.EntityFrameworkCore;

namespace FokinShop.Infrastructure.Data
{
    public class CatalogRepository<T> : RepositoryBase<T> where T : class
    {
        public CatalogRepository(CatalogContext catalogContext) : base(catalogContext)
        {
        }
    }
}
