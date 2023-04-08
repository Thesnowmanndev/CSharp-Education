List<string> students = new List<string>();
bool classFull = false;

do
{
    Console.Write("\nWould you like to add a student's name to the list? Yes or No: ");
    string addStudent = string.Empty;
    addStudent = Console.ReadLine().ToLower().Trim();
    if (addStudent == "yes" || addStudent == "no")
    {
        if (addStudent == "yes")
        {
            Console.Write("\tEnter the student's name: ");
            string studentName = Console.ReadLine().ToLower().Trim();
            students.Add(studentName);
            Console.WriteLine("\t{0} added to the Class Roster.", studentName);
        }
        if (addStudent == "no")
        {
            classFull = true;
        }
    } 
    else
    {
        Console.WriteLine("Please type Yes or No");
    }
} while (!classFull);

Console.WriteLine("There are {0} student names on the Class Roster.", students.Count);