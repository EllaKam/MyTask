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

        public Dictionary<int, double> Process(Dictionary<int, double> items)
        {
            foreach (var provider in providers)
            {
                var providerDiscount = ProviderEngine(provider, items);
                foreach (var item in providerDiscount)
                {
                    double priceOld = items[item.Key];
                    items[item.Key] = priceOld - item.Value;
                }
            }
            return items;
        }

        private Dictionary<int, double> ProviderEngine(IPromotionProvider provider, Dictionary<int, double> items)
        {
            Dictionary<int, double> result = new Dictionary<int, double>();
            var itemsDicount = provider.GetDiscountableItemIds();
            foreach (int id in itemsDicount)
            {
                double price = items[id];
                var discount = provider.GetItemDiscount(id, price);
                result.Add(id, discount);
            }
            return result;

        }


    }
}
