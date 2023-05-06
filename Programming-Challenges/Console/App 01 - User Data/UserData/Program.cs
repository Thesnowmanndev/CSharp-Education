using UserData;

PersonModel person = new();

Console.Write("Enter your full name: ");
person.FullName = Console.ReadLine();

Console.Write("Enter your age: ");
string ageText = Console.ReadLine();
int.TryParse(ageText, out int age);
person.Age = age;

Console.Write("Enter your annual income: ");
string annualIncomeText = Console.ReadLine();
double.TryParse(annualIncomeText, out double annualIncome);
person.AnnualIncome = annualIncome;

Console.WriteLine("\n\n");

Console.WriteLine($"Full name: {person.FullName}");
Console.WriteLine($"Age: {person.Age}");
Console.WriteLine($"Annual Income: ${person.AnnualIncome}");