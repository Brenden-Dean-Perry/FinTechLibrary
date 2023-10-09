using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public interface IPosition
    {
        decimal GetOpenGainLoss();
        decimal GetCurrentMarketValue();
        decimal GetCurrentNotional();
        decimal GetCurrentDeltaAdjustedNotional();
    }
}
