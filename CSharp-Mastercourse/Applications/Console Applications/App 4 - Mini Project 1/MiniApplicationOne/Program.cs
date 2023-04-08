string? name = null;

Console.Write("Enter your name: ");
name = Console.ReadLine().ToLower();

Console.Write("Enter your age: ");
string? ageText = Console.ReadLine();
bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"Your name is {name}.");
Console.WriteLine(isValidInt ? $"Your age is {age}." : "Enter a valid integer.");
Console.WriteLine();

if (name == "bob" || name == "sue")
{
    Console.WriteLine($"Welcome, Professor {name}.");
}
else if (age >= 21)
{
    Console.WriteLine($"Welcome, {name}.");
}
else
{
    int waitYears = 21 - age;
    Console.WriteLine($"Welcome, {name}. Please wait {waitYears} years until you are 21 and can take this course.");
}