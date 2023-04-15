Console.WriteLine("Welcome to the student roster application.");

List<string> names = new();

bool exit = false;
do
{
    Console.Write("Please input a name: ");
    string nameInput = Console.ReadLine().ToLower().Trim();
    names.Add(nameInput);
    Console.Write("Would you like to add another name? Yes or No: ");
    string addName = Console.ReadLine().ToLower().Trim();
    if (addName == "no")
    {
        exit = true;
    }
    else if (addName != "yes" &&  addName != "no")
    {
        Console.WriteLine("Please enter yes or no.");
    }
} while (!exit);

Console.WriteLine("Student Roster:");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{names[i]} is in attendance.");
}