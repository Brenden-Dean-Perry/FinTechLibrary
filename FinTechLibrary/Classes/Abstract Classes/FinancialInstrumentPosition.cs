using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public abstract class FinancialInstrumentPosition : IPosition
    {
        public FinancialInstrument Instrument { get; set; }
        public TradeDirectionType TradeDirection { get; set; }
        public decimal Quantity { get; set; }
 
        public decimal GetOpenGainLoss()
        {
            throw new NotImplementedException();
        }

        public virtual decimal GetCurrentMarketValue()
        {
            return (int)TradeDirection * Quantity * Instrument.CurrentPrice;
        }

        public virtual decimal GetCurrentNotional()
        {
            return GetCurrentMarketValue();
        }

        public virtual decimal GetCurrentDeltaAdjustedNotional()
        {
            return GetCurrentNotional();
        }

    }
}
