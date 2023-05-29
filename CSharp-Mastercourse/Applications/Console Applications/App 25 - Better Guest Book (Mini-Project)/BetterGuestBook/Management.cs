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
