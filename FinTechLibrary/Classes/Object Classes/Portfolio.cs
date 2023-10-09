using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class Portfolio : IPosition
    {
        private List<FinancialInstrument> positions { get; set; } = new List<FinancialInstrument>();
        private List<InstrumentTrade> tradeHistory { get; set; } = new List<InstrumentTrade>();

        public List<InstrumentTrade> GetTradeHistory()
        {
            return tradeHistory;
        }
        public void RecordTrade(InstrumentTrade instrumentTrade)
        {
            tradeHistory.Add(instrumentTrade);
        }

        public decimal GetOpenGainLoss()
        {
            decimal gainLoss = 0;
            foreach (IPosition trade in tradeHistory)
            {
                gainLoss = gainLoss + trade.GetOpenGainLoss();
            }
            return gainLoss;
        }

        public decimal GetCurrentMarketValue()
        {
            decimal marketValue = 0;
            foreach (IPosition trade in tradeHistory)
            {
                marketValue = marketValue + trade.GetCurrentMarketValue();
            }
            return marketValue;
        }

        public decimal GetCurrentNotional()
        {
            decimal notional = 0;
            foreach (IPosition trade in tradeHistory)
            {
                notional = notional + trade.GetCurrentNotional();
            }
            return notional;
        }

        public decimal GetCurrentDeltaAdjustedNotional()
        {
            decimal notional = 0;
            foreach (IPosition trade in tradeHistory)
            {
                notional = notional + trade.GetCurrentDeltaAdjustedNotional();
            }
            return notional;
        }
    }
}
