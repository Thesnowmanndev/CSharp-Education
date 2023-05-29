# Better Guest Book - using Libraries

When programming with C#, or many other languages, it is not best practice to put all of your code in your main program, or UI. Instead, it is better to use Class Libraries (.NET Framework) in case you decide to migrate your project from a Console Application to a WPF application. That way you do not have to rewrite all of your code - only the front end or UI.

---


In this project, I created a new library called `GuestBookLibrary` and added a models folder. Then created a model for a party attending the venue. I created a `Management` class to manage the logic of the Console Application. 

### GuestBookLibrary.Models.PartyModel.cs

```C#
namespace GuestBookLibrary.Models
{
    public class PartyModel
    {
        public string? PartyName { get; init; }
        public int PartySize { get; set; }  

        public PartyModel(string name, int size) 
        {
            PartyName = name;
            PartySize = size;
        }
    }
}
```

### BetterGuestBookUI.Management.cs

```C#
using GuestBookLibrary.Models;

namespace BetterGuestBookUI
{
    public class Management
    {
        private static List<PartyModel> Guests = new List<PartyModel>();

        public static void ManageGuests()
        {
            bool continueApplication;
            do
            {
                GatherGuestInformation();
                continueApplication = CheckForMore();
            } while (continueApplication);

            printParties(Guests);

            int totalGuests = GetTotalGuests(Guests);
            Console.WriteLine($"\nThere are {totalGuests} guests attending.");
        }

        private static string GetConsoleInformation(string message)
        {
            string output = "";
            Console.Write(message);
            output = Console.ReadLine().ToLower().Trim();

            return output;
        }

        private static void GatherGuestInformation()
        {
            string name = GetConsoleInformation("\nWhat is the name of the party: ");
            string sizeText = GetConsoleInformation("What is the size of the party: ");
            int.TryParse(sizeText, out int size);

            PartyModel party = new PartyModel(name, size);
            Guests.Add(party);
        }

        private static void printParties(List<PartyModel> Guests)
        {
            Console.WriteLine("\nAll parties:");
            foreach (PartyModel guest in Guests)
            {
                Console.WriteLine(guest.PartyName + " party of " + guest.PartySize + ".");
            }
        }

        private static int GetTotalGuests(List<PartyModel> Guests)
        {
            int count = 0;
            foreach (PartyModel guest in Guests)
            {
                count += guest.PartySize;
            }

            return count;
        }

        private static bool CheckForMore()
        {
            bool isMore = true;
            Console.Write("\nWould you like to continue? Yes / No: ");
            string continueText = Console.ReadLine().ToLower().Trim();

            if (continueText != "yes" && continueText != "no")
            {
                Console.WriteLine("Please enter Yes or No.");
            }
            else
            {
                if (continueText == "yes")
                {
                    isMore = true;
                }
                else if (continueText == "no")
                {
                    isMore = false;
                }
            }

            return isMore;
        }
    }
}
```

### BetterGuestBookUI.Program.cs
```C#
using BetterGuestBookUI;

Management.ManageGuests();
Console.ReadLine();
```


---

## Application Output

![example](https://github.com/Thesnowmanndev/CSharp-Education/blob/main/CSharp-Mastercourse/Applications/Console%20Applications/App%2025%20-%20Better%20Guest%20Book%20(Mini-Project)/example.png?raw=true)
