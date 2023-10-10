using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public abstract class FinancialDerivative : FinancialInstrument
    {
        public decimal CurrentSpotPriceOfUnderlyingInstrument { get; set; }
        public decimal RiskFreeInterestRate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal ContractMultiplier { get; set; }
        public decimal AnnualDividendPayoutAmount { get; set; }

        public decimal GetCurrentDividendYield()
        {
            return AnnualDividendPayoutAmount / CurrentPrice;
        }


        public double GetDaysUntilExpirationIncludingTime()
        {
            return (DateTime.Today - ExpirationDate).TotalDays;
        }

        public double GetTimeFactorInDaysPerYearIncludingTime(int daysPerYear = 360)
        {
            return GetDaysUntilExpirationIncludingTime() / daysPerYear;
        }

        public double GetDaysUntilExpiration()
        {
            return (DateTime.Today - ExpirationDate).Days;
        }

        public double GetTimeFactorInDaysPerYear(int daysPerYear = 360)
        {
            return GetDaysUntilExpiration() / daysPerYear;
        }
    }
}
