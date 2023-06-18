# Inheritance

Inheritance is a fundamental concept in object-oriented programming that allows you to create new classes based on existing classes. It enables you to define a relationship between classes where one class inherits properties and behaviors from another class, known as the base or parent class.

Imagine you have a base class called **'Animal'** that represents common characteristics and behaviors of all animals. It might have properties like *`name`* and *`age`* and methods like `eat()` and `sleep()`. Now, let's say you want to create more specific classes like **'Dog'** and **'Cat'** that have additional behaviors unique to them. Instead of rewriting the common properties and methods in each class, you can utilize inheritance.

By inheriting from the **'Animal'** class, the **'Dog'** and **'Cat'** classes automatically gain all the properties and methods defined in the **'Animal'** class. This means you can access and use the *`name`* and *`age`* properties, as well as call the `eat()` and `sleep()` methods directly from instances of **'Dog'** and **'Cat'** classes.

Inheritance promotes code reuse, reduces redundancy, and allows you to create a logical hierarchy of classes. It helps you organize your code by grouping related classes together and expressing their relationships. In addition, inheritance enables you to override methods in the derived classes, providing the ability to customize or extend the behavior inherited from the base class.

However, it's important to use inheritance judiciously. Inheritance should represent a 'is-a' relationship, where a derived class truly is a type of the base class. If the relationship between classes is more about sharing common functionality rather than a 'is-a' relationship, it's better to use other mechanisms like composition or interfaces. Remember to keep your inheritance hierarchies simple and avoid excessive levels of inheritance. Too much inheritance can lead to a complex and tightly coupled codebase, making it harder to maintain and understand. It's always recommended to favor composition over deep inheritance hierarchies whenever possible.

## Additional Resources:

https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance

---

## Vehicle Class

```C#
namespace InheritanceDemo
{
    class Vehicle
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string VehicleIdentificationNumber { get; set; }
        public string Color { get; set; }

        public int Year { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public int NumberOfSeats { get; set; }
        public int Weight { get; set; }
        public int MaxLoadCapacity { get; set; }
    }
}
```

## Car Class

```C#
namespace InheritanceDemo
{
    class Car : Vehicle 
    {
        public string CarClassification { get; set; }   
        public string BodyStyle { get; set; }
        public string EngineType { get; set; }
        public string TransmissionType { get; set; }
        public string Drivetrain { get; set; }
        public string FuelType { get; set; }

        public string[] Features { get; set; }

        public int FuelCapacity { get; set; }
        public int FuelConsumption { get; set; }
        public int NumberOfWheels { get; set; }

        public float EngineSize { get; set; }
        public float AccelerationTime { get; set; }

        public bool HasAirbags { get; set; }
    }
}
```

## Boat Class

```C#
namespace InheritanceDemo
{
    class Boat : Vehicle
    {
        public string BoatType { get; set; } // Sailboat, Motorboat, Yacht
        public string WatercraftType { get; set; } // Fishing Boat, Speedboat, Cruiser
        public string HullMaterial { get; set; }
        public string PropulsionType { get; set; }

        public string[] SafetyEquipment { get; set; }

        public int Draft { get; set; }
        public int MaximumCapacity { get; set; }
        public int FuelCapacity { get; set; }

        public float Length { get; set; }

        public bool HasNavigationSystem { get; set; }
        public bool HasCabin { get; set; }
    }
}
```

## Motorcyle Class

```C#
namespace InheritanceDemo
{
    class Motorcycle : Vehicle
    {
        public string MotorcycleType { get; set; } // Standard, Touring, Sport, ...
        public string MotorcycleCategory { get; set; } // Lighweight, Middleweight, Heavy

        public int EngineDisplacement { get; set; } // In ccs (400cc, 750cc, 1200cc)
        public int FuelCapacity { get; set; }

        public bool HasSideCar { get; set; }
    }
}
```