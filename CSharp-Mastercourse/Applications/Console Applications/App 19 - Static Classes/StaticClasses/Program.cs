using StaticClasses;

string firstName = RequestData.GetString("What is your first name: ");
double x = RequestData.GetDouble("What is the first number: ");
double y = RequestData.GetDouble("What is the second number: ");

UserMessages.ApplicationStartMessage(firstName);

double sum = CalculateData.Add(x, y);
string sumText = $"The sum of {x} + {y} is {sum}.";

UserMessages.PrintResult(sumText);