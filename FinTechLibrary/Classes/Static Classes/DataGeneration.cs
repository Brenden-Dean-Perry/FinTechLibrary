using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FinTechLibrary
{
    public static class DataGeneration
    {
       
        public static List<AssetClass> GetMockPortfolio()
        {
            List<InvestmentStrategy> strategyList = new List<InvestmentStrategy>();
            InvestmentStrategy strategy = new InvestmentStrategy();
            strategy.StrategyName = "AI Equity";
            strategyList.Add(strategy);

            InvestmentStrategy strategy2 = new InvestmentStrategy();
            strategy2.StrategyName = "Put write";
            strategyList.Add(strategy2);

            List<AssetClass> assetClasses = new List<AssetClass>();
            AssetClass Asset = new AssetClass();
            Asset.AssetClassName = "Equity";
            Asset.AssetClassOrder = 0;
            Asset.TargetAllocationPercentage = (decimal)1;
            Asset.InvestmentStrategies = strategyList;
            assetClasses.Add(Asset);

            List<InvestmentStrategy> strategyList_Fixed = new List<InvestmentStrategy>();
            InvestmentStrategy strategy_Fixed = new InvestmentStrategy();
            strategy_Fixed.StrategyName = "US Tresuries";
            strategyList_Fixed.Add(strategy_Fixed);

            InvestmentStrategy strategy_Fixed2 = new InvestmentStrategy();
            strategy_Fixed2.StrategyName = "Cash";
            strategyList_Fixed.Add(strategy_Fixed2);

            AssetClass Asset2 = new AssetClass();
            Asset2.AssetClassName = "Fixed";
            Asset2.AssetClassOrder = 1;
            Asset2.TargetAllocationPercentage = (decimal)-1;
            Asset2.InvestmentStrategies = strategyList_Fixed;
            assetClasses.Add(Asset2);

            List<InvestmentStrategy> strategyList_Debt = new List<InvestmentStrategy>();
            InvestmentStrategy strategy_Debt = new InvestmentStrategy();
            strategy_Debt.StrategyName = "Property";
            strategyList_Debt.Add(strategy_Debt);

            InvestmentStrategy strategy_Debt2 = new InvestmentStrategy();
            strategy_Debt2.StrategyName = "Vehical";
            strategyList_Debt.Add(strategy_Debt2);


            AssetClass Asset3 = new AssetClass();
            Asset3.AssetClassName = "Debt";
            Asset3.AssetClassOrder = 2;
            Asset3.TargetAllocationPercentage = (decimal)0;
            Asset3.InvestmentStrategies = strategyList_Debt;
            assetClasses.Add(Asset3);

            return assetClasses;
        }
    }
}
