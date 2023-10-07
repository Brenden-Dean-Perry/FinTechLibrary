using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public interface IFinancialLoanFactory
    {
        public FinancialLoan CreateLoanObject(LoanPaymentType paymentType);

    }
}
