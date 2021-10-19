using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPX_Pos;

namespace CustomerPPX
{
    public class ItalyCustomer : IPOS
    {
        private PassportX_POS basePos;

        public ItalyCustomer()
        {
            basePos = new PassportX_POS();
        }
        public string DisplayWelcomeScreen()
        {
            string baseString = basePos.DisplayWelcomeScreen();
            return $"{baseString} Italy customer";
        }

        public Guid CreateCustomerOrder()
        {
            throw new NotImplementedException();
        }
    }
}
