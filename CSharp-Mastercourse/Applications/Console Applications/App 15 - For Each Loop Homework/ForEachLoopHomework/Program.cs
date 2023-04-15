Console.WriteLine("Employee Roster Creator");

List<string> firstNames = new();
bool exit = false;
bool correctEntry = false;
do
{
    Console.Write("\nEnter Employee's name: ");
    string name = Console.ReadLine().ToLower().Trim();
    firstNames.Add(name);

    // Exit Application Logic
    string addEmployee = string.Empty;
    Console.Write("\nAdd another employee? Yes or No: ");
    addEmployee = Console.ReadLine().ToLower().Trim();

    if (addEmployee == "yes" || addEmployee == "no")
    {
        correctEntry = true;
    } else
    {
        correctEntry = false;
    }
    while (!correctEntry)
    {
        Console.WriteLine("Please enter a valid command.");
        Console.Write("\tAdd another employee? Yes or No: ");
        addEmployee = Console.ReadLine().ToLower().Trim();
        if (addEmployee == "yes" || addEmployee == "no")
        {
            correctEntry = true;
        }
    }
    if (addEmployee == "no")
    {
        exit = true;
    }
} while (!exit);

Console.WriteLine("\nCurrent Employees:");
foreach (string firstName in firstNames)
{
    Console.WriteLine($"{firstName}");
}