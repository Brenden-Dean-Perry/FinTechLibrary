using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public interface IFinancialOptionFactory
    {
        public FinancialOption CreateObject(OptionType optionType);

    }
}
