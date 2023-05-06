using PropertyTypes;

PersonModel person = new PersonModel();

Console.Write("What is your first name: ");
person.FirstName = Console.ReadLine();

Console.Write("What is your last name: ");
person.LastName = Console.ReadLine();

Console.Write("What is your street address: ");
person.StreetAddress = Console.ReadLine();

Console.Write("What is your city: ");
person.City = Console.ReadLine();

Console.Write("What is your state: ");
person.State = Console.ReadLine();

Console.Write("What is your postal code: ");
person.PostalCode = Console.ReadLine();

Console.WriteLine("\n\nUser Data:");
Console.WriteLine("--------------------");
Console.WriteLine($"{person.FullName}");
Console.WriteLine($"{person.FullAddress}");