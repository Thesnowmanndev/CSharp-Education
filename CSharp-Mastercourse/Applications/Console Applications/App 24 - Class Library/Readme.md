# Class Libraries

When programming with C#, or many other languages, it is not best practice to put all of your code in your main program, or UI. Instead, it is better to use Class Libraries (.NET Framework) in case you decide to migrate your project from a Console Application to a WPF application. That way you do not have to rewrite all of your code - only the front end or UI.

---

## How to add a Class Library to your project

1. First, create your console application project in Visual Studio using the .NET Framework (For this, I used the C# console application project, named the project ConsoleUI, and named the solution ConsoleLibraryDemo).
2. Click File > Add > New Project.
3. Select Class Library and click Next.
4. Name the project appropriately - i.e. SomethingLibrary (in my case I named it DemoLibrary).
5. Delete the premade Class1.cs Visual Studio creates to avoid improper naming conventions.
6. Proceed with adding folders or classes as you need for your applications in the Library project.
7. In your ConsoleUI project right click on Dependencies and click Add Project Reference.
8. Now you can add `using DemoLibrary.Models;` to the top of your ConsoleUI Program.cs file.

---

## Example

In this project, I decided to make a library to house models for Super Mario Bros characters as I was watching the new movie while programming this example.

### DemoLibrary.Models.ToadModel.cs

```C#
namespace DemoLibrary.Models
{
    public class ToadModel
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string DotColor { get; set; }
        public int Age { get; set; }

        public ToadModel(string name, string color, string dotColor, int age) 
        {
            Name = name;
            Color = color;
            DotColor = dotColor;
            Age = age;
        }

        public void Greet() 
        {
            Console.WriteLine($"Hello, my name is {Name}! I am a {Color} Mushroom with {DotColor} dots and I am {Age} years old.");
        }
    }
}
```

### ConsoleUI.Program.cs

```C#
using DemoLibrary.Models;

class Program
{
    private static void Main(string[] args)
    {
        ToadModel BlueToad = new ToadModel("Toad", "Blue", "White", 16);
        ToadModel YellowToad = new ToadModel("Jim", "White", "Yellow", 18);
        ToadModel PinkToad = new ToadModel("Amy", "Pink", "White", 21);

        BlueToad.Greet();
        YellowToad.Greet();
        PinkToad.Greet();

        Console.ReadLine();
    }
}
```

---

## Application Output

![example](https://github.com/Thesnowmanndev/CSharp-Education/blob/main/CSharp-Mastercourse/Applications/Console%20Applications/App%2024%20-%20Class%20Library/example.png?raw=true)
