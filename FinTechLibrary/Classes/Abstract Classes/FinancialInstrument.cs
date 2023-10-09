using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public abstract class FinancialInstrument
    {
        public string InstrumentTicker { get;set;}
        public decimal CurrentPrice { get;set;}
        public decimal AnnualDividendPayoutAmount { get;set;}

        public decimal getCurrentDividendYield()
        {
            return AnnualDividendPayoutAmount / CurrentInstrumentPrice;
        }

    }
}
