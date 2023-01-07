//  +----------------------------------------------------------------------------------------------------------------------+
//  GreetingApplication - (c) 2023 TheSnowmannDev @ Github. All Rights Reserved.
//
//  This is the second application I wrote during Section 1 of C# Mastercourse by Tim Corey. I wrote the application 
//  prior to watching the videos where the instructor writes the application. I am familiar with C# due to college 
//  courses and decided to use that knowledge to write this given the requirements of the application. The requirements
//  can be found in the Readme.md of this applications Github directory.
//
//      GreetingApplication is free software: you can redistribute it and/or modify
//      it under the terms of the GNU General Public License as published by
//      the Free Software Foundation, either version 3 of the Licenses, or  
//      (at you option) any later version.
//
//  +----------------------------------------------------------------------------------------------------------------------+

class GreetingApp
{
    public static string? Username { get; set; }
    static readonly string Border = "+-------------------------------------------------+";
    static readonly string Greeting = "Welcome to this application!";
    static readonly string QueryName = "What is your chosen name for this application?";
    static readonly string Greet = "Hello ";

    public static void BoilerPlate()
    {
        Console.WriteLine(Border);
        Console.WriteLine();
        Console.WriteLine(Greeting);
        Console.WriteLine();
        Console.WriteLine(QueryName);   
    }

    public static void ReadUserInput()
    {
        Username = Console.ReadLine();
    }

    public static void GreetUser() 
    {
        Console.WriteLine();
        Console.WriteLine(Greet + Username + ".");
        Console.WriteLine();
        Console.WriteLine(Border);
        ExitMenu();
    }

    public static void ExitMenu() 
    {
        Console.WriteLine();
        Console.WriteLine("Would you like to exit the application?");
        Console.WriteLine("Y : Yes \t N : No");
        string Exit = Console.ReadLine().ToUpper();
        switch (Exit)
        {
            case "Y": { ExitApplication(); break; }
            case "N": { GreetUser(); break; }
            default: { ExitMenu(); break;}
        }
    }

    public static void ExitApplication() 
    {
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }

    public static void RunApplication()
    {
        BoilerPlate();
        ReadUserInput();
        GreetUser();
    }

    static public void Main(string[] args)
    {
        GreetingApp greetingApp= new();
        RunApplication();
    }
}