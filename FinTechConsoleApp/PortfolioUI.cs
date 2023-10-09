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
            foreach(AssetClass assetClass in portfolio.GetPortfolioStructure())
            {
                Console.WriteLine(assetClass.AssetClassName + "\t" + ObjectToText.Percent(assetClass.TargetAllocationPercentage,2));
                
                foreach(InvestmentStrategy strategy in assetClass.InvestmentStrategies)
                {
                    Console.WriteLine("\t" + strategy.StrategyName);
                }
            }
        }

        public static void ShowTradeHistory(Portfolio portfolio)
        {
            ConsoleHeaderWriteLine("Trade History:");
            foreach(InstrumentTrade trade in portfolio.GetTradeHistory())
            {
                Console.WriteLine(trade.TradeDateTime + " | " + trade.TradeType.ToString() + " | " + trade.Quantity + " | " + trade.TradePrice);
            }
        }
    }
}
