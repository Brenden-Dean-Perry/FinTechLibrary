using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class FinancialLoanPosition : FinancialInstrumentPosition, IPosition
    {
        public new FinancialLoan Instrument { get; set; }

        public override decimal GetCurrentMarketValue()
        {
            return (int)TradeDirection * Instrument.LoanAmount;
        }

        public override decimal GetCurrentNotional()
        {
            return GetCurrentMarketValue();
        }

        public override decimal GetCurrentDeltaAdjustedNotional()
        {
            return GetCurrentMarketValue();
        }

    }
}
