using FinTechLibrary;
using GeneralOperationalLibrary;

Console.WriteLine("Program starting...");

FinancialLoanFactory LoanFactory = new FinancialLoanFactory();
FinancialLoan loan = LoanFactory.CreateObject(LoanPaymentType.FullAmortization);
loan.LoanAmount = 100;
loan.PeriodInterestRate = (decimal)0.1;
loan.Periods = 10;
decimal interestPaid = loan.TotalPaymentsOverLifeOfLoan();

Console.WriteLine("Payment:" + ObjectToText.NumberWithCommas(loan.PaymentAmountPerPeriod(),2));
Console.WriteLine("Interest Paid:" + interestPaid.ToString());
Console.WriteLine("Interest rate:" + ObjectToText.Percent(loan.PeriodInterestRate,4));
Console.WriteLine("Outstanding loan balance:" + ObjectToText.NumberWithCommas(loan.OutstandingLoanBalance((decimal)9.999999),2));


FinancialOptionFactory OptionFactory = new FinancialOptionFactory();
FinancialOption option = OptionFactory.CreateObject(OptionType.Put);
option.CurrentPrice = 10;
option.ExpirationDate = DateTime.Parse("12/1/2023");
option.ContractMultiplier = 1;
option.CurrentSpotPriceOfUnderlyingInstrument = 4200;
option.Delta = (decimal)0.5;

InstrumentTrade_DerivativePutOption callTrade = new InstrumentTrade_DerivativePutOption();
callTrade.Instrument = option;
callTrade.Quantity = 1;
callTrade.TradePrice = 10;
callTrade.TradeType = TradeType.Sell;


FinancialOption putoption = OptionFactory.CreateObject(OptionType.Put);
putoption.CurrentPrice = 10;
putoption.ExpirationDate = DateTime.Parse("12/1/2023");
putoption.ContractMultiplier = 1;
putoption.CurrentSpotPriceOfUnderlyingInstrument = 4200;
putoption.Delta = (decimal)-0.5;


FinancialInstrumentFactory factory = new FinancialInstrumentFactory();
FinancialInstrument spy = factory.CreateObject(FinancialInstrumentType.Equity);
spy.InstrumentTicker = "SPY";
spy.CurrentPrice = 4200;

InstrumentTrade_Physical trade_spy = new InstrumentTrade_Physical();
trade_spy.Instrument = spy;
trade_spy.Quantity = 10;
trade_spy.TradeType = TradeType.Sell;
trade_spy.TradePrice = 4400;


//goldFutures.setCurrentPrice(1840);
//goldFutures.setInstrumentTicker("MGZ3");
//DateTime expiration = DateTime.Parse("12/10/2023");
//goldFutures.SetExpirationDate(expiration);
//goldFutures.SetContractMultipler(50);

//InstrumentTrade_DerivativeDelta1 trade = new InstrumentTrade_DerivativeDelta1();
//trade.Instrument = goldFutures;
//trade.Quantity = 1;
//trade.TradePrice = (1740);
//trade.TradeType = TradeType.Sell;


Portfolio portfolio = new Portfolio();
portfolio.RecordTrade(trade_spy);
portfolio.RecordTrade(callTrade);

PortfolioUI.ShowDataSummary(portfolio);

Console.WriteLine("Price update:");
spy.CurrentPrice = 3200;

PortfolioUI.ShowDataSummary(portfolio);

PortfolioUI.ShowTradeHistory(portfolio);

Console.ReadLine();
