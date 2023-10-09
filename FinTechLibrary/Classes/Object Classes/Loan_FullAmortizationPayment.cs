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

        public override decimal OutstandingLoanBalance(decimal PeriodsPassed)
        {
            decimal FullPeriodsPassed = Math.Truncate(PeriodsPassed);
            decimal PartialPeriodPassed = PeriodsPassed - FullPeriodsPassed;
            decimal TotalPaymentsMade = PaymentAmountPerPeriod() * FullPeriodsPassed;
            return LoanAmount + TotalInterestIncurred(PeriodsPassed) - TotalPaymentsMade;
        }

        private decimal TotalInterestIncurred(decimal PeriodsPassed)
        {
            decimal FullPeriodsPassed = Math.Truncate(PeriodsPassed);
            decimal PartialPeriodPassed = PeriodsPassed - FullPeriodsPassed;

            decimal totalInterestIncurred = 0;
            decimal CurrentLoanBalance = LoanAmount;
            for (int i = 0; i < FullPeriodsPassed; i++)
            {
                decimal accruedInterestOverPeriod = CurrentLoanBalance * PeriodInterestRate;
                totalInterestIncurred = totalInterestIncurred + accruedInterestOverPeriod;
                CurrentLoanBalance = CurrentLoanBalance + accruedInterestOverPeriod - PaymentAmountPerPeriod();
            }
            totalInterestIncurred = totalInterestIncurred + CurrentLoanBalance * PeriodInterestRate * PartialPeriodPassed;
            return totalInterestIncurred;
        }


    }
}
