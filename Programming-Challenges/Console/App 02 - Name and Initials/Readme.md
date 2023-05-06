# Name and Initials

Write a program that has the following string variables: firstName, middleName, and lastName. Ask the user for the applicable information. The program should also have the following char variables: firstInitial, middleInitial, and lastInitial. Store the users first, middle, and last initials in these variables. The program should display the contents of these variables on the screen. 

# Application Example

## [Program.cs](https://github.com/Thesnowmanndev/CSharp-Education/blob/main/Programming-Challenges/Console/App%2002%20-%20Name%20and%20Initials/NameAndInitials/Program.cs)

```
using NameAndInitials;

PersonModel person = new();

Console.Write("Enter your first name: ");
person.FirstName = Console.ReadLine();
Console.Write("Enter your middle name: ");
person.MiddleName = Console.ReadLine();
Console.Write("Enter your last name: ");
person.LastName = Console.ReadLine();

Console.WriteLine($"\n{person.FirstName} {person.MiddleName} {person.LastName}'s initials are {person.FirstInitial}{person.MiddleInitial}{person.LastInitial}.");

```

## [PersonModel.cs](https://github.com/Thesnowmanndev/CSharp-Education/blob/main/Programming-Challenges/Console/App%2002%20-%20Name%20and%20Initials/NameAndInitials/PersonModel.cs)

```
namespace NameAndInitials
{
    internal class PersonModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }  
        public string LastName { get; set; }

        public char FirstInitial
        {
            get { return FirstName[0]; }
        }
        public char MiddleInitial
        {
            get { return MiddleName[0]; }
        }
        public char LastInitial
        {
            get { return LastName[0]; }
        }
    }
}

```

## Application in Operation:
![example](https://github.com/Thesnowmanndev/CSharp-Education/blob/main/Programming-Challenges/Console/App%2002%20-%20Name%20and%20Initials/example.png?raw=true)