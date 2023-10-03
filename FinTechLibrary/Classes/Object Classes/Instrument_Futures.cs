using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal class Instrument_Futures : FinancialInstrumentDerivative
    {
        public string GetFuturesMarketDescription()
        {
            if(this.GetFuturesPriceBasis() > 0)
            {
                return "Contango";
            }
            else if(this.GetFuturesPriceBasis() == 0)
            {
                return "Flat";
            }
            else
            {
                return "Backwardation";
            }
        }

        public decimal GetFuturesPriceBasis()
        {
            return currentInstrumentPrice - currentSpotPriceOfUnderlyingInstrument;
        }

        public string GetFuturesFairValueDescription()
        {
            if (this.GetFuturesMispricing() > 0)
            {
                return "Rich";
            }
            else if(this.GetFuturesMispricing() == 0)
            {
                return "Fairly Valued";
            }
            else
            {
                return "Cheap";
            }
        }

        public decimal GetFuturesMispricing()
        {
            return currentInstrumentPrice - GetFuturesFairValuePrice();
        }

        public decimal GetFuturesFairValuePrice(int daysPerYear = 360)
        {
            double futureValueFactor = Math_Finance.FutureValueFactor((double)riskFreeInterestRate, GetTimeFactorInDaysPerYear(daysPerYear));
            decimal futureValueOfPrice = currentSpotPriceOfUnderlyingInstrument * (decimal)futureValueFactor;
            decimal dividendInIndexPoints = getAnnualDividendPayoutAmount() * (decimal)GetTimeFactorInDaysPerYear(daysPerYear);
            return futureValueOfPrice - dividendInIndexPoints;
        }
    }
}
