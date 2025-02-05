namespace FokinShop.ApplicationCore.Entities
{
    public class CatalogType
    {
        public int Id { get; private set; }
        public string Type { get; private set; }
        public CatalogType(int id, string type)
        {
            Id = id;
            Type = type;
        }
    }
}
