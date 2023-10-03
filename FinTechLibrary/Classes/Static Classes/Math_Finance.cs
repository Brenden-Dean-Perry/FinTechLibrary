﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public static class Math_Finance
    {
        public static double FutureValue(double presentValue, double interestRateOverTimePeriod, double timePeriod)
        {
            return presentValue * FutureValueFactor(interestRateOverTimePeriod, timePeriod);
        }

        public static double FutureValueFactor(double interestRateOverPeriod, double periods)
        {
            return Math.Pow(1 + interestRateOverPeriod, periods);
        }

        public static double PresentValueFactor(double interestRateOverPeriod, double periods)
        {
            return 1 / FutureValueFactor(interestRateOverPeriod, periods);
        }
    }
}
