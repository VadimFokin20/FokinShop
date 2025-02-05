using FokinShop.ApplicationCore.Entities;

namespace FokinShop.Infrastructure.Data
{
    public class SeedCatalogContext
    {
        public static List<CatalogBrand> GetCatalogBrands()
        {
            return new List<CatalogBrand>()
            {
                new(1, "Hugo"),
                new(2, "Tommy Hilfiger"),
                new(3, "Marc O'Polo"),
                new(4, "FokinShop"),
                new(5, "Gucci")
            };
        }

        public static List<CatalogType> GetCatalogTypes()
        {
            return new List<CatalogType>()
            {
                new(1, "T-Shirt"),
                new(2, "Hoodie"),
                new(3, "Blazer"),
                new(4, "Trousers"),
            };
        }

        public static List<ProductSize> GetProductSizes()
        {
            return new()
            {
                new(1, Sizes.XS),
                new(2, Sizes.S),
                new(3, Sizes.M),
                new(4, Sizes.L),
                new(5, Sizes.XL)
            };
        }

        public static List<CatalogItem> GetCatalogItems()
        {
            var startData = new List<CatalogItem>()
            {
                new(1, "Black Hugo T-Short", "{imagesourceurl}/img/t-shorts/hugo/5436843-01.jpg", 4999M, 5, 1, 1),
                new(2, "Dark Blue Hugo T-Short", "{imagesourceurl}/img/t-shorts/hugo/5357203-01.jpg", 4999M, 5, 1, 1),
                new(3, "White FokinShop T-Short", "{imagesourceurl}/img/t-shorts/fokinshop/t-short-01.jpg", 2999M, 5, 1, 4),
                new(4, "Black FokinShop T-Short", "{imagesourceurl}/img/t-shorts/fokinshop/5437228-01.jpg", 2999M, 5, 1, 4),
                new(5, "White Tommy Hilfiger T-Short", "{imagesourceurl}/img/t-shorts/tommy/5367271-01.jpg", 3999M, 5, 1, 2),
                new(6, "Black Tommy Hilfiger T-Short", "{imagesourceurl}/img/t-shorts/tommy/5401923-01.jpg", 3999M, 5, 1, 2),
                new(7, "Grey Marco O'Polo T-Short", "{imagesourceurl}/img/t-shorts/marcopolo/5124049_1.jpg", 3999M, 5, 1, 3),
                new(8, "Purple Marco O'Polo T-Short", "{imagesourceurl}/img/t-shorts/marcopolo/5382664-01.jpg", 3999M, 5, 1, 3),

                new(9, "Black Hugo Hoodie", "{imagesourceurl}/img/hoodies/hugo/5357198_01.jpg", 11999M, 5, 2, 1),
                new(10, "Dark Blue Hugo Hoodie", "{imagesourceurl}/img/hoodies/hugo/hoodie_01.jpg", 11999M, 5, 2, 1),
                new(11, "Rocket FokinShop Hoodie", "{imagesourceurl}/img/hoodies/fokinshop/5186197_1.jpg", 6999M, 5, 2, 4),
                new(12, "Fire FokinShop Hoodie", "{imagesourceurl}/img/hoodies/fokinshop/5443678-01.jpg", 6999M, 5, 2, 4),
                new(13, "Black Tommy Hilfiger Hoodie", "{imagesourceurl}/img/hoodies/tommy/5293622_01.jpg", 14999M, 5, 2, 2),
                new(14, "Blue Tommy Hilfiger Hoodie", "{imagesourceurl}/img/hoodies/tommy/5453826-01.jpg", 14999M, 5, 2, 2),
                new(15, "Marco O'Polo Hoodie", "{imagesourceurl}/img/hoodies/marcopolo/5293791-1.jpg", 13999M, 5, 2, 3),
                new(16, "Dark Blue Marco O'Polo Hoodie", "{imagesourceurl}/img/hoodies/marcopolo/5382573_01.jpg", 13999M, 5, 2, 3),

                new(17, "Beige Blue Hugo Trousers", "{imagesourceurl}/img/trousers/hugo/5278010_1.jpg", 8999M, 5, 4, 1),
                new(18, "Black Hugo Trousers", "{imagesourceurl}/img/trousers/hugo/5321324_1.jpg", 8999M, 5, 4, 1),
                new(19, "Dark Blue FokinShop Trousers", "{imagesourceurl}/img/trousers/fokinshop/5300987-1.jpg", 5999M, 5, 4, 4),
                new(20, "Fire FokinShop Trousers", "{imagesourceurl}/img/trousers/fokinshop/651a7f69.png", 5999M, 5, 4, 4),
                new(21, "Dark Blue Tommy Trousers", "{imagesourceurl}/img/trousers/tommy/5453702-01.jpg", 9999M, 5, 4, 2),
                new(22, "Dark Blue Marco O'Polo Trousers", "{imagesourceurl}/img/trousers/marcopolo/5276578_1.jpg", 7999M, 5, 4, 3),

                new(23, "Black Hugo Blazer", "{imagesourceurl}/img/blazers/hugo/4758119-1.jpg", 50999M, 5, 3, 1),
                new(24, "Grey Hugo Blazer", "{imagesourceurl}/img/blazers/hugo/5436803-01.jpg", 40999M, 5, 3, 1),
                new(25, "Dark Blue FokinShop Blazer", "{imagesourceurl}/img/blazers/fokinshop/5381314-01.jpg", 20999M, 5, 3, 4),
                new(26, "Dark Blue FokinShop Blazer", "{imagesourceurl}/img/blazers/fokinshop/5423289-01.jpg", 30999M, 5, 3, 4),
                new(27, "Dark Blue Marco O'Polo Blazer", "{imagesourceurl}/img/blazers/marcopolo/5382601-01.jpg", 30999M, 5, 3, 3),

                new(28, "White Gucci T-Short", "{imagesourceurl}/img/t-shorts/gucci/353a0a1b-f774-49cc-be64-2cc71c96676d.png", 29999M, 5, 1, 5),
                new(29, "Dark Blue Gucci T-Short", "{imagesourceurl}/img/t-shorts/gucci/3cf77df4-2432-4c82-9e87-eb33ea6b9d0b.png", 29999M, 5, 1, 5),
                new(30, "Grey Gucci Hoodie", "{imagesourceurl}/img/hoodies/gucci/480bc362-83b1-450e-8296-cb76521d7e2a.png", 64999M, 5, 2, 5),
                new(31, "Black Gucci Hoodie", "{imagesourceurl}/img/hoodies/gucci/ac405c36-5dd4-4053-8afa-8b7d9bb6143b.png", 59999M, 5, 2, 5),
                new(32, "Grey Gucci Trousers", "{imagesourceurl}/img/trousers/gucci/36082786-7be2-428a-b264-ffe67c5da35c.png", 39999M, 5, 4, 5),
                new(33, "Black Gucci Trousers", "{imagesourceurl}/img/trousers/gucci/01e350ec-0bda-4df4-9f3c-9461734bcb78.png", 44999M, 5, 4, 5),
                new(34, "Dark Blue Gucci Blazer", "{imagesourceurl}/img/blazers/gucci/a7ad7d90-fa2a-4ef6-b8d4-34e5d629d2bf.png", 250499M, 5, 3, 5),
                new(35, "Dark Blue Gucci Blazer", "{imagesourceurl}/img/blazers/gucci/cf34c282-cf60-4993-b4cc-581045bb09b2.png", 200499M, 5, 3, 5),
            };

            var shuffledData = startData.OrderBy(_ => new Random().Next()).ToList();

            int count = shuffledData.Count();
            for (int i = 0; i < count; i++)
                shuffledData[i].Id = i+1;

            return shuffledData;
        }

        public static List<object> GetCatalogItemProductSize()
        {
            var catalogItems = GetCatalogItems();
            var sizes = GetProductSizes();
            List<object> items = new List<object>();

            foreach (var ci in catalogItems)
            {
                var rnd = new Random();
                int count = rnd.Next(sizes.Count() - 1);
                for (int i = 0; i <= count; i ++)
                {
                    int choose = rnd.Next(1, sizes.Count());
                    if (!ci.ProductSizes.Any(s => (int)s.Size == choose))
                    {
                        var ps = sizes.ToList().FirstOrDefault(i => i.Size == (Sizes)choose);
                        if(ps != null)
                        {
                            ps.CatalogItems.Add(ci);
                            ci.ProductSizes.Add(ps);
                            items.Add(new { CatalogItemId = ci.Id, ProductSizeId = ps.Id });
                        }
                    }
                }
            }

            return items;
        }
    }
}
