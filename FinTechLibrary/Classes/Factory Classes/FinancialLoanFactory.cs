using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public class FinancialLoanFactory : IFinancialLoanFactory
    {
        public FinancialLoan CreateObject(LoanPaymentType paymentType)
        {
            switch (paymentType)
            {
                case LoanPaymentType.FullAmortization:
                    return new Loan_FullAmortizationPayment();
                case LoanPaymentType.InterestOnly:
                    return new Loan_InterestOnlyPayment();
                default:
                    throw new TypeLoadException();
            }
        }

    }
}
