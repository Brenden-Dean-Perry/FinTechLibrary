using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public abstract class FinancialOption : FinancialInstrumentDerivative
    {
        internal decimal optionStrikePrice { get; set; }
        internal decimal historicalVolatilityOfUnderlyingInstrument { get; set; }
        internal decimal impliedVolatilityOfUnderlyingInstrument { get; set; }
        internal decimal delta { get; set; }
        internal decimal gamma { get; set; }
        internal decimal theta { get; set; }
        internal decimal vega { get; set; }
        internal decimal rho { get; set; }

    }
}
