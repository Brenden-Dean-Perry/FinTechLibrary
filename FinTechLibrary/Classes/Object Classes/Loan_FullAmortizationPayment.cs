using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal class Loan_FullAmortizationPayment : FinancialLoan
    {
        public override decimal TotalPaymentsOverLifeOfLoan()
        {
            decimal paymentAmount = LoanAmount * PeriodInterestRate;
            return paymentAmount * Periods;
        }

        public override decimal TotalInterestOverLifeOfLoan()
        {
            return TotalPaymentsOverLifeOfLoan() - LoanAmount;
        }

        public override decimal RemainingLoanBalance(int Period)
        {
            throw new NotImplementedException();
        }
    }
}
