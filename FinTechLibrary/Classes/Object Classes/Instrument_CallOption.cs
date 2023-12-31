﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinTechLibrary
{
    internal class Instrument_CallOption : FinancialOption, IFinancialOption
    {
        public decimal GetIntrisicValue()
        {
            return Math.Max(CurrentSpotPriceOfUnderlyingInstrument - OptionStrikePrice, 0);
        }

        public decimal GetTimeValue()
        {
            return CurrentPrice - GetIntrisicValue();
        }
    }
}
