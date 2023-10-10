using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class InstrumentTrade_DerivativeCallOption : InstrumentTrade
    {
        public new FinancialOption Instrument { get; set; }
        public override decimal GetOpenGainLoss()
        {
            decimal changeInPrice = (Instrument.CurrentPrice - base.TradePrice);
            decimal direction = (int)base.TradeDirectionType;
            return direction * changeInPrice * base.Quantity * Instrument.ContractMultiplier;
        }

        public override decimal GetCurrentMarketValue()
        {
            decimal direction = (int)base.TradeDirectionType;
            return direction * Instrument.CurrentPrice * base.Quantity * Instrument.ContractMultiplier;
        }

        public override decimal GetCurrentNotional()
        {
            decimal direction = (int)base.TradeDirectionType;
            return direction * Instrument.CurrentSpotPriceOfUnderlyingInstrument * base.Quantity * Instrument.ContractMultiplier;
        }

        public override decimal GetCurrentDeltaAdjustedNotional()
        {
            return GetCurrentNotional() * Instrument.Delta;
        }
    }
}
