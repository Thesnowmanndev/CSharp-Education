# Property Types (Shorthand: prop || propfull)

## Auto Properties (Visual Studio)
---
Auto properties in Visual Studio are shorthand syntax for defining properties in C# classes. Auto properties allow you to quickly declare properties without writing the explicit getter and setter methods.

The syntax for auto properties is as follows:

```
public <type> <PropertyName> { get; set; }
```

Example code from the project:

```
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
```

In the above code, the PersonModel class has two auto properties: FirstName and LastName. Both properties have a public access modifier (public), and they can be accessed and modified from outside the class. The get and set keywords indicate that the properties have both a getter and a setter, allowing read and write access.

When you use auto properties, the compiler automatically generates the underlying private field and the getter and setter methods. This makes it more concise and reduces the amount of boilerplate code you need to write.

You can also customize the accessibility of the getter or setter individually. For example, you can make the getter private and the setter public, or vice versa. Here's an example:

```
public class Person
{
    public string Name { get; private set; }
    public int Age { get; set; }
}
```

In this modified code, the Name property has a private setter, which means it can only be set within the class itself. The Age property, on the other hand, has both a public getter and setter.

Auto properties provide a convenient way to define properties in C# classes while reducing the verbosity of the code. They are widely used in scenarios where you don't need to add additional logic or validation in the getter or setter methods.

---

# Homework: 

## Instructions:
Create a class that has properties for street address, city, state, and zip code. Then add a FullAddress property that is read-only.

## Example: 
!example

## Code:
To see the code source: PersonModel.cs, Program.cs