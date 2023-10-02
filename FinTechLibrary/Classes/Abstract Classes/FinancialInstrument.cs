using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public abstract class FinancialInstrument : ITrade
    {
        internal string instrumentTicker { get;set;}
        internal decimal currentInstrumentPrice { get;set;}
        internal decimal costBasisInstrumentPrice { get;set;}
        internal decimal annualDividendPayoutAmount { get;set;}

        public string Buy()
        {
            return "Instrument was purchased!";
        }

        public void Sell()
        {
            throw new NotImplementedException();
        }

        public string getTicker()
        {
            return instrumentTicker;
        }

        public void setCurrentPrice(decimal price)
        {
            currentInstrumentPrice = price;
        }

        public decimal getCurrentPrice()
        {
            return currentInstrumentPrice;
        }

        public void setCurrentCostBasisPrice(decimal price)
        {
            costBasisInstrumentPrice = price;
        }

        public decimal getCurrentCostBasisPrice()
        {
            return costBasisInstrumentPrice;
        }
        public decimal getOpenGainLoss()
        {
            return currentInstrumentPrice - costBasisInstrumentPrice;
        }

        public void setAnnualdDividendPayoutAmount(decimal AnnualDividendPayoutAmount)
        {
            annualDividendPayoutAmount = AnnualDividendPayoutAmount;
        }

        public decimal getAnnualDividendPayoutAmount()
        {
            return annualDividendPayoutAmount;
        }

        public decimal getCurrentDividendYield()
        {
            return annualDividendPayoutAmount / currentInstrumentPrice;
        }

    }
}
