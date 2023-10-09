using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public abstract class FinancialLoanPosition : FinancialInstrumentPosition, IPosition
    {
        public FinancialLoan Instrument { get; set; }

        public decimal GetCurrentMarketValue()
        {
            return (int)TradeDirection * Instrument.LoanAmount;
        }

        public decimal GetCurrentNotional()
        {
            return GetCurrentMarketValue();
        }

        public decimal GetCurrentDeltaAdjustedNotional()
        {
            return GetCurrentMarketValue();
        }

        public decimal GetOpenGainLoss()
        {
            throw new NotImplementedException();
        }
    }
}
