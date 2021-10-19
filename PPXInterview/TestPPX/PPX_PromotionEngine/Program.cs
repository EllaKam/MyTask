using System.Collections.Generic;
using System.Linq;
using PPXModel;

namespace PPX_PromotionEngine
{
    public class Program
    {
        static void Main(string[] args)
        {
            var items = new List<Item>
            {
                new Item { Id = 1, Price = 20 },
                new Item { Id = 2, Price = 2 },
                new Item { Id = 3, Price = 7 },
                new Item { Id = 4, Price = 8 },
                new Item { Id = 5, Price = 10 },
                new Item { Id = 6, Price = 5 },
                new Item { Id = 7, Price = 20 },
                new Item { Id = 8, Price = 20 },
                new Item { Id = 9, Price = 9 },
                new Item { Id = 10, Price = 16 },
                new Item { Id = 11, Price = 17 },
                new Item { Id = 12, Price = 17 },
                new Item { Id = 13, Price = 17 }
            };
            Dictionary<int, double> itemsPrice = new Dictionary<int, double>();
            foreach (Item item in items)
            {
                itemsPrice.Add(item.Id, item.Price);
            }

            var promotionEngine = new PromotionEngine();
            promotionEngine.GetDiscountsNew(items);
            //promotionEngine.GetDiscounts(items);

        }
    }
}
