# Instantiated Classes

Instantiation is the process of creating a new object for a class using the 'new' keyword. You can write a class to act as the blueprint and then create a instance of the class with code to store data within that instance. 

## PersonModel.cs :
```
namespace InstantiatedClasses
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GitHub { get; set; } 
    }
}
```

## Program.cs :
```
using InstantiatedClasses;

List<PersonModel> people = new List<PersonModel>();
string input = "";

do
{
    Console.Write("\nWhat is your first name (or type exit to stop): ");
    input = Console.ReadLine();

    if (input.ToLower() != "exit")
    {
        // Instantiates Class:
        PersonModel person = new PersonModel();

        // Sets Data per blueprint: 
        person.FirstName = input;

        Console.Write("What is your last name: ");
        input = Console.ReadLine();
        person.LastName = input;

        Console.Write("What is your GitHub username: ");
        input = Console.ReadLine();
        person.GitHub = input;

        people.Add(person);
    }
} while (input.ToLower() != "exit");

Console.WriteLine("\n\nData:");
foreach (PersonModel person in people)
{
    Console.WriteLine($"- {person.FirstName} {person.LastName}.");
    Console.WriteLine($"\tGitHub username: {person.GitHub}");
}
```

# App Example:

!example