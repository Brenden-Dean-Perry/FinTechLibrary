using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class FinancialInstrumentPosition : IPosition
    {
        public FinancialInstrument Instrument { get; set; }
        public decimal Quantity { get; set; }

        public decimal GetCurrentDeltaAdjustedNotional()
        {
            throw new NotImplementedException();
        }

        public decimal GetCurrentMarketValue()
        {
            throw new NotImplementedException();
        }

        public decimal GetCurrentNotional()
        {
            throw new NotImplementedException();
        }

        public decimal GetOpenGainLoss()
        {
            throw new NotImplementedException();
        }
    }
}
