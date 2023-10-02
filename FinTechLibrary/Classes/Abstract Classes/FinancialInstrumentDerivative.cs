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

        public double getDaysUntilExpirationIncludingTime()
        {
            return (DateTime.Today - expirationDate).TotalDays;
        }

        public double getTimeFactorInDaysPerYearIncludingTime(int daysPerYear = 360)
        {
            return getDaysUntilExpirationIncludingTime() / daysPerYear;
        }

        public double getDaysUntilExpiration()
        {
            return (DateTime.Today - expirationDate).Days;
        }

        public double getTimeFactorInDaysPerYear(int daysPerYear = 360)
        {
            return getDaysUntilExpiration() / daysPerYear;
        }

        public void setExpirationDate(DateTime dateTime)
        {
            expirationDate = dateTime;
        }

        public DateTime GetExpirationDate()
        {
            return expirationDate;
        }
    }
}
