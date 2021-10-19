using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPX_Pos;

namespace CustomerPPX
{
    public interface ICustomerFactory
    {
        IPOS Create(string country);
    }
}
