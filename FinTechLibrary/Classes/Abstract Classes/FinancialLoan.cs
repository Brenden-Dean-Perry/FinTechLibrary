using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FinTechLibrary
{
    public abstract class FinancialLoan : FinancialInstrument
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

        public DataTable GetLoanAmoritizationSchedule()
        {
            DataTable loanSchedule = new DataTable();
            loanSchedule.Columns.Add("Period", typeof(int));
            loanSchedule.Columns.Add("StartingLoanBalance", typeof(decimal));
            loanSchedule.Columns.Add("InterestAccrued", typeof(decimal));
            loanSchedule.Columns.Add("PeriodPayment", typeof(decimal));
            loanSchedule.Columns.Add("EndingLoanBalance", typeof(decimal));

            for (int i = 0; i < Periods; i++)
            {
                DataRow row = loanSchedule.NewRow();
                row["Period"] = i;
                row["StartingLoanBalance"] = OutstandingLoanBalance(i);
                row["InterestAccrued"] = OutstandingLoanBalance(i) * PeriodInterestRate;
                row["PeriodPayment"] = PaymentAmountPerPeriod();
                row["EndingLoanBalance"] = OutstandingLoanBalance(i) + OutstandingLoanBalance(i) * PeriodInterestRate - PaymentAmountPerPeriod();
                loanSchedule.Rows.Add(row);
            }

            return loanSchedule;
        }
    }
}
