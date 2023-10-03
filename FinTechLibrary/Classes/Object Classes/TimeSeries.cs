using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal class TimeSeries
    {
        Dictionary<DateTime, decimal> timeSeries = new Dictionary<DateTime, decimal>();

        public decimal AverageValue()
        {
            return timeSeries.Values.Average();
        }

        public long CountValues()
        {
            return timeSeries.Values.LongCount();
        }

        public decimal TotalPercentChange()
        {
            DateTime minDateTime = timeSeries.Keys.Min();
            DateTime maxDateTime = timeSeries.Keys.Max();

            decimal startingValue = timeSeries.GetValueOrDefault(minDateTime);
            decimal endingValue = timeSeries.GetValueOrDefault(maxDateTime);

            return (endingValue - startingValue) / startingValue;
        }
    }
}
