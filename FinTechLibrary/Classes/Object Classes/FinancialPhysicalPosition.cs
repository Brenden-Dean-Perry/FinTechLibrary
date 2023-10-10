using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class FinancialPhysicalPosition : FinancialInstrumentPosition
    {
        public new FinancialInstrument Instrument { get; set; }
    }
}
