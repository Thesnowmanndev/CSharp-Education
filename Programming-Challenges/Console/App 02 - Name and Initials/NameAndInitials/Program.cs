using NameAndInitials;

PersonModel person = new();

Console.Write("Enter your first name: ");
person.FirstName = Console.ReadLine();

Console.Write("Enter your middle name: ");
person.MiddleName = Console.ReadLine();

Console.Write("Enter your last name: ");
person.LastName = Console.ReadLine();

Console.WriteLine($"\n{person.FirstName} {person.MiddleName} {person.LastName}'s initials are " +
                         $"{person.FirstInitial}{person.MiddleInitial}{person.LastInitial}.");
