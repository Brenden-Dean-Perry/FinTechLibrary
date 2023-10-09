using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal class Instrument_Futures : FinancialDerivative
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
            return base.Instrument.CurrentPrice - CurrentSpotPriceOfUnderlyingInstrument;
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
            return base.Instrument.CurrentPrice - GetFuturesFairValuePrice();
        }

        public decimal GetFuturesFairValuePrice(int daysPerYear = 360)
        {
            double futureValueFactor = Math_Finance.FutureValueFactor((double)RiskFreeInterestRate, GetTimeFactorInDaysPerYear(daysPerYear));
            decimal futureValueOfPrice = CurrentSpotPriceOfUnderlyingInstrument * (decimal)futureValueFactor;
            decimal dividendInIndexPoints = base.Instrument.AnnualDividendPayoutAmount * (decimal)GetTimeFactorInDaysPerYear(daysPerYear);
            return futureValueOfPrice - dividendInIndexPoints;
        }
    }
}
