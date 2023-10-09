using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal class Loan_InterestOnlyPayment : FinancialLoan
    {
        public override decimal PaymentAmountPerPeriod()
        {
            return LoanAmount * PeriodInterestRate;
        }

        public override decimal OutstandingLoanBalance(decimal PeriodsPassed)
        {
            decimal PartialPeriodPassed = PeriodsPassed - Math.Truncate(PeriodsPassed);
            decimal accumulatedInterestDue = LoanAmount * PeriodInterestRate * PartialPeriodPassed;
            return LoanAmount + accumulatedInterestDue;
        }
    }
}
