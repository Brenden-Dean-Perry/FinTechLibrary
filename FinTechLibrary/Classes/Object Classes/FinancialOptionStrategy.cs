using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class FinancialOptionStrategy : IFinancialOptionStrategy
    {
        public List<IFinancialOption> FinancialOptions { get; set; } = new List<IFinancialOption>();

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
