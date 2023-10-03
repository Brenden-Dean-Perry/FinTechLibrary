using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal class Instrument_FixedIncome : FinancialInstrument
    {
        //Macaulay Duration is a weighted average of the times until the cash flows are recieved
        internal decimal macaulayDuration { get; set; }
        //Modified duration is the interest rate sensitivity of a bond's price
        internal decimal modifiedDuration { get; set; }
        //Effective duration is similar to modified duration but its cash flows are option adjusted
        internal decimal effectiveDuration { get; set; }
        internal decimal convexity { get; set; }
    }
}
