using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinTechLibrary
{
    internal class Instrument_CallOption : FinancialOption
    {
        public decimal getIntrisicValue()
        {
            return Math.Max(currentSpotPriceOfUnderlyingInstrument - optionStrikePrice, 0);
        }

        public decimal getImpliedValue()
        {
            return currentInstrumentPrice - getIntrisicValue();
        }


    }
}
