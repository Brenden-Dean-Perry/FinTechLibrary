using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public abstract class FinancialLoan
    {
        public decimal LoanAmount { get; set; }
        public decimal Periods { get; set; }
        public decimal PeriodInterestRate { get; set; }

        public abstract decimal PaymentAmountPerPeriod();
        public abstract decimal OutstandingLoanBalance(decimal PeriodsPassed);

        public decimal TotalPaymentsOverLifeOfLoan()
        {
            return PaymentAmountPerPeriod() * Periods;
        }

        public decimal TotalInterestOverLifeOfLoan()
        {
            return TotalPaymentsOverLifeOfLoan() - LoanAmount;
        }

        public bool HasPartialPeriodInterestAccrued(decimal Periods)
        {
            decimal FullPeriodsPassed = Math.Truncate(Periods);
            decimal PartialPeriodPassed = Periods - FullPeriodsPassed;

            if(PartialPeriodPassed > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
