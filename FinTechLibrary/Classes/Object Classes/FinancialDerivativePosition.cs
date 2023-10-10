using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class FinancialDerivativePosition : FinancialInstrumentPosition,  IPosition
    {
        public FinancialDerivative DerivativeInstrument { get; set; }

        public override decimal GetCurrentNotional()
        {
            return (int)TradeDirection * DerivativeInstrument.ContractMultiplier * Quantity * DerivativeInstrument.CurrentSpotPriceOfUnderlyingInstrument;
        }

        public override decimal GetCurrentDeltaAdjustedNotional()
        {
            return GetCurrentNotional();
        }
    }
}
