using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class InstrumentTrade_DerivativeDelta1 : InstrumentTrade
    {
        public FinancialInstrumentDerivative Instrument { get; set; }

        public override decimal GetOpenGainLoss()
        {
            decimal changeInPrice = (Instrument.getCurrentPrice() - base.TradePrice);
            decimal direction = (int)base.TradeType;
            return direction * changeInPrice * base.Quantity * Instrument.contractMultiplier;
        }

        public override decimal GetCurrentMarketValue()
        {
            return GetOpenGainLoss();
        }

        public override decimal GetCurrentNotional()
        {
            decimal direction = (int)base.TradeType;
            return direction * Instrument.currentInstrumentPrice * base.Quantity * Instrument.contractMultiplier;
        }

        public override decimal GetCurrentDeltaAdjustedNotional()
        {
            return GetCurrentNotional();
        }
    }
}
