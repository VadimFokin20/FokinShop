namespace FokinShop.Web.Models
{
    public class PaginationViewModel
    {
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int? Previous { get; set; }
        public int? Next { get; set; }
    }
}
