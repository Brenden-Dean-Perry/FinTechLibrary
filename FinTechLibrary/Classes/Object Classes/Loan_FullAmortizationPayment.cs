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
            return (decimal)Math_Finance.LoanPayment((double)LoanAmount, (double)PeriodInterestRate, Periods);
        }

        public override decimal OutstandingLoanBalance(decimal Period)
        {
            decimal FullPeriodsPassed = Math.Truncate(Period);
            decimal TotalPaymentsMade = PaymentAmountPerPeriod() * FullPeriodsPassed;
            return LoanAmount + TotalInterestIncurred(0,0) - TotalPaymentsMade;
        }

        private decimal TotalInterestIncurred(decimal CurrentLoanBalance, int period)
        {
            if(period == 0)
            {
                return 0;
            }
            return 1;
        }


    }
}
