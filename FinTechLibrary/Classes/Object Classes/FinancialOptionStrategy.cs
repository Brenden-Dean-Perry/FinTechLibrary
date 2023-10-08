using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class FinancialOptionStrategy
    {
        public List<IFinancialOption> FinancialOptions { get; set; } = new List<IFinancialOption>();
    }
}
