using StaticClassesHomework;

List<decimal> items = new();

ControlData.InputItems(items);
decimal accountBalance = ControlData.InputBalance();
decimal totalCost = CalculateData.Add(items);
decimal newAccountBalance = CalculateData.SubtractFromBalance(accountBalance, totalCost);

GenerateMessages.PrintItems(items);

string totalCostText = GenerateMessages.PrintTotal(items);
Console.WriteLine(totalCostText);

string accountBalanceText = GenerateMessages.PrintNewAccountBalance(accountBalance, totalCost);
Console.WriteLine(accountBalanceText);

