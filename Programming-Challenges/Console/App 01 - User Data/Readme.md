# 1. Name, Age, and Annual Income

Write a program that declares the following:
- a String variable for the users name
- a int variable for the users age
- a double variable for the users annual pay

Store the users age, name, and annual income in these variables. The program should display these values in the console.

## Application Example:

### Program.cs
```
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
```

### PersonModel.cs
```
namespace UserData
{
    internal class PersonModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public double AnnualIncome { get; set; }
    }
}
```

### Application being ran:
!example