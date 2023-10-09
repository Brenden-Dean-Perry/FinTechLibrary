using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class AssetClass : IPosition
    {
        public string AssetClassName { get; set; }
        public decimal TargetAllocationPercentage { get; set; }
        public int AssetClassOrder { get; set; } = 0;
        public List<InvestmentStrategy> InvestmentStrategies { get; set; } = new List<InvestmentStrategy>();

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
