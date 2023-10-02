using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    internal abstract class FinancialInstrument : ITrade
    {
        internal string instrumentTicker { get;set;}
        internal decimal currentInstrumentPrice { get;set;}
        internal decimal costBasisInstrumentPrice { get;set;}


        public void Buy()
        {
            throw new NotImplementedException();
        }

        public void Sell()
        {
            throw new NotImplementedException();
        }

        public  string getTicker()
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

        public decimal getCurrentCostBasisPrice()
        {
            return costBasisInstrumentPrice;
        }
        public decimal getOpenGainLoss()
        {
            return currentInstrumentPrice - costBasisInstrumentPrice;
        }
    }
}
