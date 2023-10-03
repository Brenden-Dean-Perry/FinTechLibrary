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

Console.ReadLine();
