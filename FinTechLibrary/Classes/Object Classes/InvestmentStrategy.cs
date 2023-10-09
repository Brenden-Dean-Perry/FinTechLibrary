using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class InvestmentStrategy : IPosition
    {
        public string StrategyName { get; set; }
        public int StrategyOrder { get; set; } = 0;
        public List<FinancialInstrument> Positions { get; set; } = new List<FinancialInstrument>();

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
