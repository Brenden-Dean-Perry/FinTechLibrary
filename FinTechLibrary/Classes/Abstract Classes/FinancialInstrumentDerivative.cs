using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public abstract class FinancialInstrumentDerivative : FinancialInstrument
    {
        internal decimal currentSpotPriceOfUnderlyingInstrument { get; set; }
        internal decimal riskFreeInterestRate { get; set; }
        internal DateTime expirationDate { get; set; }

        public double GetDaysUntilExpirationIncludingTime()
        {
            return (DateTime.Today - expirationDate).TotalDays;
        }

        public double GetTimeFactorInDaysPerYearIncludingTime(int daysPerYear = 360)
        {
            return GetDaysUntilExpirationIncludingTime() / daysPerYear;
        }

        public double GetDaysUntilExpiration()
        {
            return (DateTime.Today - expirationDate).Days;
        }

        public double GetTimeFactorInDaysPerYear(int daysPerYear = 360)
        {
            return GetDaysUntilExpiration() / daysPerYear;
        }

        public void SetExpirationDate(DateTime dateTime)
        {
            expirationDate = dateTime;
        }

        public DateTime GetExpirationDate()
        {
            return expirationDate;
        }
    }
}
