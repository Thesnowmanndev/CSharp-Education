bool exit = false;

do
{
    string name = string.Empty;
    Console.Write("What is your name: ");
    name = Console.ReadLine().ToLower();

    if (name == "kyle") 
    { 
        Console.WriteLine($"Welcome Admin {name}."); 
    }
    else 
    { 
        Console.WriteLine($"Welcome User {name}."); 
    }

    string exitText = String.Empty;
    Console.Write("To exit the application, type exit: ");
    exitText = Console.ReadLine().ToLower();

    if (exitText == "exit") 
    { 
        exit = true; 
    }

}  while (!exit);