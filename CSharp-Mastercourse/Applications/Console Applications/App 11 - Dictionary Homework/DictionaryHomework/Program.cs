Dictionary<int, string> employees = new Dictionary<int, string>();
employees.Add(1, "Kyle");
employees.Add(2, "Haley");
employees.Add(3, "Kierra");
employees.Add(4, "Rachel");
employees.Add(5, "Reilly");
employees.Add(6, "Marlene");
employees.Add(7, "Duncan");
employees.Add(8, "Trevin");
employees.Add(9, "Ricky");
employees.Add(10, "Warren");

bool correctEntry = false;
do
{
    Console.Write("Enter an employee ID from 1 to {0}: ", employees.Count);
    string entryText = Console.ReadLine().ToLower().Trim();
    bool isValidInt = int.TryParse(entryText, out int id);

    if (id > 0 && id < employees.Count)
    {
        Console.WriteLine("ID #{0} is {1}.", id, employees[id]);
        Console.Write("Would you like to lookup another record? Yes or No: ");
        string exitText = Console.ReadLine().ToLower().Trim();
        if (exitText != "yes" && exitText != "no")
        {
            Console.WriteLine("Please enter a valid command.");
        }
        else if (exitText == "no")
        {
            correctEntry = true;
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid ID #");
    }
} while (!correctEntry);
