using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPXModel;

namespace PPX_PromotionEngine
{
    public interface IPromotionManager
    {
        void AddProvider(IPromotionProvider provider);
        Dictionary<int, double> Process(Dictionary<int, double> items);

    }
}
