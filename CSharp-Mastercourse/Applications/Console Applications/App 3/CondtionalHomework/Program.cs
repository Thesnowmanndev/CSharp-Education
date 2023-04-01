Console.Write("Enter your name: ");
string? name = Console.ReadLine().ToLower();

if (name == "kyle")
{
    Console.WriteLine($"Welcome, Admin {name}.");
}
else
{
    Console.WriteLine($"Welcome, Technician {name}.");
}