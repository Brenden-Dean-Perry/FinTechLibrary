using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary 
{ 
    internal class Instrument_PutOption : FinancialOption, IFinancialOption
    {
        public decimal GetIntrisicValue()
        {
            return Math.Max(optionStrikePrice - currentSpotPriceOfUnderlyingInstrument, 0);
        }

        public decimal GetTimeValue()
        {
            return currentInstrumentPrice - GetIntrisicValue();
        }
    }
}
