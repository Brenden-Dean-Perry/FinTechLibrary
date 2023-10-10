using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralOperationalLibrary;

namespace FinTechLibrary
{
    internal static class PortfolioUI
    {
        public static void ConsoleHeaderWriteLine(string message)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShowDataSummaryStatistics(Portfolio portfolio)
        {
            ConsoleHeaderWriteLine("Portfolio Statistics:");
            Console.WriteLine("Open G/L: " + ObjectToText.NumberWithCommas(portfolio.GetOpenGainLoss(), 2));
            Console.WriteLine("Current MV: " + ObjectToText.NumberWithCommas(portfolio.GetCurrentMarketValue(), 2));
            Console.WriteLine("Current Notional: " + ObjectToText.NumberWithCommas(portfolio.GetCurrentNotional(), 2));
            Console.WriteLine("Current Delta Adjusted Notional: " + ObjectToText.NumberWithCommas(portfolio.GetCurrentDeltaAdjustedNotional(), 2));
        }

        public static void ShowPortfolioStructure(Portfolio portfolio)
        {
            ConsoleHeaderWriteLine("Portfolio structure:");
            Console.WriteLine("Asset Class" + "\t\t\t" + "Target Weight");
            Console.WriteLine("-----------------------------------------");
            foreach (AssetClass assetClass in portfolio.GetPortfolioStructure())
            {
                Console.WriteLine(assetClass.AssetClassName + "\t\t\t\t" + ObjectToText.Percent(assetClass.TargetAllocationPercentage,2));
                int i = 1;
                foreach(InvestmentStrategy strategy in assetClass.InvestmentStrategies)
                {
                    Console.WriteLine("\t" + "Strategy " + i.ToString() + ": " + strategy.StrategyName);
                    i++;
                }
                Console.WriteLine();
            }
        }

        public static void ShowTradeHistory(Portfolio portfolio)
        {
            ConsoleHeaderWriteLine("Trade History:");
            Console.WriteLine("Trade Date | Direction | Quantity | Trade Price");
            foreach (InstrumentTrade trade in portfolio.GetTradeHistory())
            {
                Console.WriteLine(trade.TradeDateTime + " | " + trade.TradeDirectionType.ToString() + " | " + trade.Quantity + " | " + trade.TradePrice);
            }
        }

        
    }
}
