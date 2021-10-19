using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visa;

namespace PPX_PromotionEngine
{
    public class PromotionProvider : IPromotionProvider
    {
        private dynamic promotionProvider;
        public PromotionProvider(dynamic provider)
        {
            promotionProvider = provider;
        }
        public List<int> GetDiscountableItemIds()
        {
            try
            {
                return promotionProvider.GetDiscountableItemIds();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public double GetItemDiscount(int item, double price)
        {
            double result = 0;
            try
            {
                result = promotionProvider.GetItemDiscount(item, price);
            }
            catch { }

            return result;
        }
    }
}
