using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal abstract class FinancialInstrumentDerivative : FinancialInstrument
    {
        internal decimal currentSpotPriceOfUnderlyingInstrument { get; set; }
        internal decimal riskFreeRate { get; set; }
        internal DateTime expirationDate { get; set; }

    }
}
