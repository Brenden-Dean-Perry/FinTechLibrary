using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal class Loan_FullAmortizationPayment : FinancialLoan
    {
        public override decimal PaymentAmountPerPeriod()
        {
            return (decimal)Math_Finance.LoanPayment((double)LoanAmount, (double)PeriodInterestRate, (int)Periods);
        }

        public override decimal OutstandingLoanBalance(decimal PeriodsInTheFuture)
        {
            return CurrentLoanBalance_Recursive(LoanAmount, PeriodsInTheFuture);
        }

        private decimal CurrentLoanBalance_Recursive(decimal CurrentLoanBalance, decimal PeriodsInTheFuture)
        {
            decimal FullPeriodsPassed = Math.Truncate(PeriodsInTheFuture);
            
            if (FullPeriodsPassed > 0)
            {
                CurrentLoanBalance = CurrentLoanBalance + (CurrentLoanBalance * PeriodInterestRate) - PaymentAmountPerPeriod();
                CurrentLoanBalance = CurrentLoanBalance_Recursive(CurrentLoanBalance, PeriodsInTheFuture - 1);
            }
            else if(HasPartialPeriodInterestAccrued(PeriodsInTheFuture) == true)
            {
                decimal PartialPeriodPassed = PeriodsInTheFuture - FullPeriodsPassed;
                CurrentLoanBalance = CurrentLoanBalance + CurrentLoanBalance * PeriodInterestRate * PartialPeriodPassed;
            }

            return CurrentLoanBalance;   
        }

    }
}
