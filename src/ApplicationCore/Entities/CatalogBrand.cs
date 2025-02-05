namespace FokinShop.ApplicationCore.Entities
{
    public class CatalogBrand
    {
        public int Id { get; private set; }
        public string Brand {  get; private set; }
        public CatalogBrand(int id, string brand) 
        { 
            Id = id;
            Brand = brand;
        }
    }
}
