using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class InstrumentTrade_Physical : InstrumentTrade
    {
        public FinancialInstrument Instrument { get; set; }

        public override decimal GetOpenGainLoss()
        {
            decimal changeInPrice = (Instrument.CurrentPrice - base.TradePrice);
            decimal direction = (int)base.TradeType;
            return direction * changeInPrice * base.Quantity;
        }

        public override decimal GetCurrentMarketValue()
        {
            decimal direction = (int)base.TradeType;
            return direction * Instrument.CurrentPrice * base.Quantity;
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
