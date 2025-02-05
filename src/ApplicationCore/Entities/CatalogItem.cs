namespace FokinShop.ApplicationCore.Entities
{
    public class CatalogItem
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string PictureUri { get; private set; }
        public decimal Price { get; private set; }
        public int? Rating { get; private set; }
        public int CatalogTypeId { get; private set; }
        public CatalogType? CatalogType { get; private set; }
        public int CatalogBrandId { get; private set; }
        public CatalogBrand? CatalogBrand { get; private set; }
        public List<ProductSize> ProductSizes { get; set; } = [];

        public CatalogItem(int id,
                           string name,
                           string pictureUri,
                           decimal price,
                           int? rating,
                           int catalogTypeId,
                           int catalogBrandId)
        {
            Id = id;
            Name = name;
            PictureUri = pictureUri;
            Price = price;
            Rating = rating;
            CatalogTypeId = catalogTypeId;
            CatalogBrandId = catalogBrandId;
        }
    }
}
