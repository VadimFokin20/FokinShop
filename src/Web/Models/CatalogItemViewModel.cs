using FokinShop.ApplicationCore.Entities;

namespace FokinShop.Web.Models
{
    public class CatalogItemViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PictureUri { get; set; }
        public int? Rating { get; set; }
        public List<ProductSize> ProductSizes { get; set; } = new();
        public decimal Price { get; set; }
    }
}
