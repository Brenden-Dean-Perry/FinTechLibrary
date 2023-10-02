using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal abstract class FinancialOption : FinancialInstrumentDerivative
    {
        internal decimal optionStrikePrice { get; set; }
        internal decimal volatilityOfUnderlyingInstrument { get; set; }

        internal decimal getTimeTillExpiration()
        {
            throw new NotImplementedException();
        }

    }
}
