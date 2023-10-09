using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal abstract class FinancialOptionPosition : FinancialDerivativePosition, IPosition
    {
        public new FinancialOption Instrument { get; set; }

        public override decimal GetCurrentDeltaAdjustedNotional()
        {
            return base.GetCurrentNotional() * Math.Abs(Instrument.Delta);
        }


    }
}
