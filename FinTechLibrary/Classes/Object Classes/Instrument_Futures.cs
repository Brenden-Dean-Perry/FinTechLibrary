using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal class Instrument_Futures : FinancialInstrumentDerivative
    {
        public string getFuturesMarketDescription()
        {
            if(this.getFuturesPriceBasis() > 0)
            {
                return "Contango";
            }
            else
            {
                return "Backwardation";
            }
        }

        public decimal getFuturesPriceBasis()
        {
            return currentInstrumentPrice - currentSpotPriceOfUnderlyingInstrument;
        }

        public string getFuturesFairValueDescription()
        {
            if (this.getFuturesMispricing() > 0)
            {
                return "Rich";
            }
            else
            {
                return "Cheap";
            }
        }

        public decimal getFuturesMispricing()
        {
            //Returns the richness/cheapness of futures
            return currentInstrumentPrice - getFuturesFairValuePrice();
        }

        public decimal getFuturesFairValuePrice()
        {
            return currentInstrumentPrice - currentSpotPriceOfUnderlyingInstrument;
        }
    }
}
