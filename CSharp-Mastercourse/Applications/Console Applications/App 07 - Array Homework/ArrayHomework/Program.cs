bool exit = false;
string exitText = string.Empty;
string[] names = new string[] { "James", "Brenda", "Kaleb", "Amber", "Sam" };
int i = 0;
string choiceText = string.Empty;

do
{
    Console.WriteLine("\nThere are currently {0} names in the database. Which name would you like to retrieve?", names.Length);
    Console.Write("1 to {0}: ", names.Length);
    choiceText = Console.ReadLine();
    bool isValidInt = int.TryParse(choiceText, out i);

    if (i > 0 && i < 6)
    {
        Console.WriteLine("The Chosen Records Data: {0}", names[i - 1]);
    } 
    else
    {
        Console.WriteLine("\nPlease choose a valid record.");
    }

    bool correctOption = false;
    do
    {
        Console.Write("\nWould you like to exit? Yes or No: ");
        exitText = Console.ReadLine().ToLower();
        if (exitText == "yes" || exitText == "no")
        {
            correctOption = true;
            if (exitText == "yes")
            {
                exit = true;
            }
        }
        else
        {
            Console.WriteLine("Please choose a correct option.");
            correctOption = false;
        }
    } while(!correctOption);
}  while (!exit);