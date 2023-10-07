using FinTechLibrary;

Console.WriteLine("Program starting...");

Instrument_CallOption callOption = new Instrument_CallOption();
callOption.setCurrentPrice(100);
decimal price = callOption.getCurrentPrice();

int reset = (int)ResetOccurance.Daily;
Console.WriteLine(reset.ToString());
string message = callOption.Buy();
Console.WriteLine(message + " At Price: " + price.ToString());

Console.WriteLine(Math_Finance.FutureValue(100, 0.05, 10).ToString());


FinancialLoanFactoryImp LoanFactoryImp = new FinancialLoanFactoryImp();
FinancialLoan loan = LoanFactoryImp.CreateLoanObject(LoanPaymentType.FullAmortization);
loan.LoanAmount = 100;
loan.PeriodInterestRate = (decimal)0.1;
loan.Periods = 10;
decimal interestPaid = loan.TotalPaymentsOverLifeOfLoan();

Console.WriteLine("Payment:" + loan.PaymentAmountPerPeriod().ToString());
Console.WriteLine("Interest Paid:" + interestPaid.ToString());
Console.WriteLine("Interest rate:" + loan.PeriodInterestRate.ToString());
Console.WriteLine("Outstanding loan balance:" + loan.RemainingLoanBalance((decimal)5.5));


Console.ReadLine();
