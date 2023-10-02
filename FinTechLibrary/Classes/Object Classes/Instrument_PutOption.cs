using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary 
{ 
    internal class Instrument_PutOption : FinancialOption
    {
        public decimal getIntrisicValue()
        {
            return Math.Max(optionStrikePrice - currentSpotPriceOfUnderlyingInstrument, 0);
        }

        public decimal getImpliedValue()
        {
            return currentInstrumentPrice - getIntrisicValue();
        }
    }
}
