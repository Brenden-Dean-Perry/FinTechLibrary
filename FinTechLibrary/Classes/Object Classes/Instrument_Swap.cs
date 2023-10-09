using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal class Instrument_Swap : FinancialInstrument
    {
        public string PayLegTicker { get; set; }
        public decimal PayLegCostBasisPrice { get; set; }
        public decimal PayLegCurrentPrice { get; set; }


        public string ReceiveLegTicker { get; set; }
        public decimal ReceiveLegCostBasisPrice { get; set; }
        public decimal ReceiveLegCurrentPrice { get; set; }

        public decimal FinancingSpread { get; set; }
        public DateTime[] ResetDateSchedule { get; set; }

    }
}
