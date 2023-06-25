# Interface

An interface is a programming construct that defines a contract or a set of rules for classes to follow. It defines a blueprint for what a class should implement without specifying the implementation details. An interface declares a collection of methods, properties, events, or indexers that a class implementing the interface must provide.

An interface declaration declares zero or more members. The members of an interface shall be methods, properties, events, or indexers. An interface cannot contain constants, fields, operators, instance constructors, finalizers, or types, nor can an interface contain static members of any kind.

All interface members implicitly have public access. It is a compile-time error for interface member declarations to include any modifiers.

## Additional Resources:

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/interfaces

---

## IShape 

```C#
namespace InterfacesDemo.Models
{
    public interface IShape
    {
        void Draw();

        double CalculateArea();
    }
}

```

## Circle

```C#
using InterfacesDemo.Models;

namespace InterfacesDemo
{
    public class Circle : IShape
    {
        const double PIE = 3.14;

        public double CalculateArea()
        {
            double area = 0;

            Console.Write("What is the radius of the circle: ");
            string? questionRadius = Console.ReadLine().Trim();
            bool validDouble = double.TryParse(questionRadius, out double radius);

            while (!validDouble)
            {
                Console.Write("What is the radius of the circle: ");
                questionRadius = Console.ReadLine().Trim();
                validDouble = double.TryParse(questionRadius, out radius);
            }

            area = PIE * (radius * radius);

            return area;
        }

        public void Draw()
        {
            // Code rest of method
            throw new NotImplementedException();
        }
    }
}

```

## Square

```C#
using InterfacesDemo.Models;

namespace InterfacesDemo
{
    public class Square : IShape
    {
        public double CalculateArea()
        {
            double area = 0;

            Console.Write("What is the width of the square: ");
            string? questionWidth = Console.ReadLine().Trim();
            bool validDouble = double.TryParse(questionWidth, out double width);

            while (!validDouble)
            {
                Console.Write("What is the width of the square: ");
                questionWidth = Console.ReadLine().Trim();
                validDouble = double.TryParse(questionWidth, out width);
            }

            Console.Write("What is the height of the square: ");
            string? questionHeight = Console.ReadLine().Trim();
            validDouble = double.TryParse(questionHeight, out double height);

            while (!validDouble)
            {
                Console.Write("What is the height of the square: ");
                questionHeight = Console.ReadLine().Trim();
                validDouble = double.TryParse(questionHeight, out height);
            }

            area = width * height;

            return area;
        }

        public void Draw()
        {
            // Code rest of method
            throw new NotImplementedException();
        }
    }
}

```