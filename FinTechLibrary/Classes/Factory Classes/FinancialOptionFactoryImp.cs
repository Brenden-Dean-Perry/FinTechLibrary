using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal class FinancialOptionFactoryImp : IFinancialOptionFactory
    {
        public FinancialOption CreateObject(OptionType optionType)
        {
            switch (optionType)
            {
                case OptionType.Call:
                    return new Instrument_CallOption();
                case OptionType.Put:
                    return new Instrument_PutOption();
                default:
                    throw new TypeLoadException();
            }
        }
    }
}
