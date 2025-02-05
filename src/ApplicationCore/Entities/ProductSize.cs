namespace FokinShop.ApplicationCore.Entities
{
    public class ProductSize
    {
        public int Id { get; private set; }
        public Sizes Size {  get; private set; }
        public List<CatalogItem> CatalogItems { get; set; } = [];

        public ProductSize(int id, Sizes size)
        {
            Id = id;
            Size = size;
        }
    }

    public enum Sizes : byte
    {
        All,
        XS,
        S,
        M,
        L,
        XL
    }
}
