int age = 0;
int years = 25;

Console.Write("What is your age: ");
string? ageText = Console.ReadLine();
bool isValidInput = int.TryParse(ageText, out age);

Console.WriteLine(isValidInput ? $"Your age is {age}." : "Your input is not valid.");

int futureAge = age + years;
int pastAge = age - years;
Console.WriteLine($"Twenty five years from now you will be {futureAge} years old. Twenty five years ago you were {pastAge} years old.");