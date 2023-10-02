using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal class Instrument_Swap : FinancialInstrument
    {
        internal string payLegTicker { get; set; }
        internal decimal payLegCostBasisPrice { get; set; }
        internal decimal payLegCurrentPrice { get; set; }


        internal string recieveLegTicker { get; set; }
        internal decimal recieveLegCostBasisPrice { get; set; }
        internal decimal recieveLegCurrentPrice { get; set; }
        
        internal decimal financingSpread { get; set; }
        internal DateTime[] resetDateSchedule { get; set; }

    }
}
