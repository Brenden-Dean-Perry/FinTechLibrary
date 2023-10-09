using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class FinancialInstrumentFactory : IFinancialInstrumentFactory
    {
        public FinancialInstrument CreateObject(FinancialInstrumentType InstrumentType)
        {
            switch (InstrumentType)
            {
                case FinancialInstrumentType.Equity:
                    return new Instrument_Equity();
                case FinancialInstrumentType.FixedIncome:
                    return new Instrument_FixedIncome();
                default:
                    throw new TypeLoadException();
            }
        }
    }
}
