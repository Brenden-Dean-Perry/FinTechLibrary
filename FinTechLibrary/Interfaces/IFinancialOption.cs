using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal interface IFinancialOption
    {
        decimal GetIntrisicValue();

        decimal GetTimeValue();

    }
}
