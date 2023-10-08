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
        public int Periods { get; set; }
        public decimal PeriodInterestRate { get; set; }

        public abstract decimal PaymentAmountPerPeriod();
        public abstract decimal OutstandingLoanBalance(decimal period);

        public decimal TotalPaymentsOverLifeOfLoan()
        {
            return PaymentAmountPerPeriod() * Periods;
        }

        public decimal TotalInterestOverLifeOfLoan()
        {
            return TotalPaymentsOverLifeOfLoan() - LoanAmount;
        }
    }
}
