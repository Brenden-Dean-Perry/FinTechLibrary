using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class InstrumentTrade_DerivativeOption : InstrumentTrade
    {
        public FinancialOption Instrument { get; set; }

        public override decimal GetOpenGainLoss()
        {
            decimal changeInPrice = (Instrument.getCurrentPrice() - base.TradePrice);
            decimal direction = (int)base.TradeType;
            return direction * changeInPrice * base.Quantity * Instrument.contractMultiplier;
        }
        public override decimal GetCurrentMarketValue()
        {
            decimal direction = (int)base.TradeType;
            return direction * Instrument.getCurrentPrice() * base.Quantity * Instrument.contractMultiplier;
        }

        public override decimal GetCurrentNotional()
        {
            decimal direction = (int)base.TradeType;
            return direction * Instrument.getCurrentPrice() * base.Quantity * Instrument.contractMultiplier;
        }

        public override decimal GetCurrentDeltaAdjustedNotional()
        {
            return GetCurrentNotional() * Instrument.delta;
        }






    }
}
