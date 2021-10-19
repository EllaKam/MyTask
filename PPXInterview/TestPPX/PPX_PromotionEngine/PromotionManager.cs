using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPXModel;

namespace PPX_PromotionEngine
{
    public class PromotionManager : IPromotionManager
    {
        private List<IPromotionProvider> providers;

        public PromotionManager()
        {
            providers = new List<IPromotionProvider>();
        }

        public void AddProvider(IPromotionProvider provider)
        {
            providers.Add(provider);
        }

        public List<(Item item, double newPrice)> Process(List<Item> items)
        {
            Dictionary<IPromotionProvider, List<int>> discountListProvider = new Dictionary<IPromotionProvider, List<int>>();

            foreach (var provider in providers)
            {
                var itemsDiscount = provider.GetDiscountableItemIds();
                if (itemsDiscount != null)
                {
                    discountListProvider.Add(provider, itemsDiscount);
                }
            }
            var result = new List<(Item, double)>();
            foreach (Item item in items)
            {
                foreach (var discountProvider in discountListProvider)
                {
                    if (discountProvider.Value.Contains(item.Id))
                    {
                        double discount = discountProvider.Key.GetItemDiscount(item.Id, item.Price);
                        item.Price -= discount;
                    }
                    result.Add((item, item.Price));
                }
            }
            return result;
        }


    }
}
