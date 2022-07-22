using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingDayDal;

namespace TradingDayDalTests
{
    internal class ExtensionMethodsSample
    {
        void CheckString()
        {
            string plz = "44797";

            if (double.TryParse(plz, out double zahl))
            {

            }
        }

        void CheckString2()
        {
            string plz = "44797";

            if (StringHelper.IsNumeric(plz))
            {

            }
        }

        void CHeckString3()
        {
            string plz = "44797";

            if (plz.IsNumeric())
            {

            }
        }
    }
}
