using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public abstract class InstrumentTrade : IPosition
    {
        public FinancialInstrument Instrument { get; set; }
        public TradeType TradeType { get; set; }
        public decimal Quantity { get; set; }
        public DateTime TradeDateTime { get; set; }
        public decimal TradePrice { get; set; }
        public abstract decimal GetOpenGainLoss();
        public abstract decimal GetCurrentMarketValue();
        public abstract decimal GetCurrentNotional();
        public abstract decimal GetCurrentDeltaAdjustedNotional();
    }
}
