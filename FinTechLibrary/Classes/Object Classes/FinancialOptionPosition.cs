using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class FinancialOptionPosition : FinancialDerivativePosition, IPosition
    {
        public FinancialOption OptionInstrument { get; set; }

        public override decimal GetCurrentDeltaAdjustedNotional()
        {
            return base.GetCurrentNotional() * Math.Abs(OptionInstrument.Delta);
        }


    }
}
