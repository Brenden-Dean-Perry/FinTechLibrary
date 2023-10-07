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
FinancialLoan loan = LoanFactoryImp.CreateLoanObject(LoanPaymentType.InterestOnly);
loan.LoanAmount = 100;
loan.PeriodInterestRate = (decimal)0.0522;
loan.Periods = 10;
decimal interestPaid = loan.TotalPaymentsOverLifeOfLoan();

Console.WriteLine("Interest Paid:" + interestPaid.ToString());
Console.WriteLine("Interest rate:" + loan.PeriodInterestRate.ToString());


Console.ReadLine();
