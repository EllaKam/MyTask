using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPX_Pos;

namespace CustomerPPX
{
    public class CustomerFactory : ICustomerFactory
    {
        public IPOS Create(string country)
        {
            if (country.Equals("Italy"))
            {
                return new ItalyCustomer();
            }

            return null;
        }
    }
}
