using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public abstract class FinancialOption : FinancialInstrumentDerivative
    {
        public decimal OptionStrikePrice { get; set; }
        public decimal HistoricalVolatilityOfUnderlyingInstrument { get; set; }
        public decimal ImpliedVolatilityOfUnderlyingInstrument { get; set; }
        public decimal Delta { get; set; }
        public decimal Gamma { get; set; }
        public decimal Theta { get; set; }
        public decimal Vega { get; set; }
        public decimal Rho { get; set; }

    }
}
