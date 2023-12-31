﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class FinancialOptionStrategy : IFinancialOptionStrategy, IPosition
    {
        public List<IFinancialOption> FinancialOptions { get; set; } = new List<IFinancialOption>();

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

        public decimal GetStrategyDelta()
        {
            throw new NotImplementedException();
        }

        public decimal GetStrategyGamma()
        {
            throw new NotImplementedException();
        }

        public decimal GetStrategyUnrealizedGL()
        {
            throw new NotImplementedException();
        }
    }
}
