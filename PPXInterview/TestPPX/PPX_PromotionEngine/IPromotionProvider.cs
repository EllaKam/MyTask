using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPX_PromotionEngine
{
    public interface IPromotionProvider
    {
        List<int> GetDiscountableItemIds();
        double GetItemDiscount(int item, double price);

    }
}
