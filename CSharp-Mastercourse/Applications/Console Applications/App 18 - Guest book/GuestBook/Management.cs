using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBook;


namespace GuestBook
{
    public class Management
    {

        private static string inquirePartyName()
        {
            Console.Write("\nWhat is the name of the party: ");
            string name = Console.ReadLine().ToLower().Trim();
            return name;
        }

        private static int addPartyGuests()
        {
            Console.Write("How many members are in the party: ");
            string amountOfGuestsText = Console.ReadLine().ToLower().Trim();
            int.TryParse(amountOfGuestsText, out int count);
            return count;
        }

        private static void printPartyNames(List<string> guestNames)
        {
            Console.WriteLine("\nAll party names:");
            foreach (string guestName in guestNames)
            {
                Console.WriteLine($"{guestName}");
            }
        }

        public static void manageGuests()
        {
            List<string> guestNames = new List<string>();
            bool continueApplication = true;
            int totalGuests = 0;

            do
            {
                guestNames.Add(inquirePartyName());
                totalGuests += addPartyGuests();

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
                        continueApplication = true;
                    }
                    else if (continueText == "no")
                    {
                        continueApplication = false;
                    }
                }
            } while (continueApplication);

            printPartyNames(guestNames);
            Console.WriteLine($"\nTotal number of guests: {totalGuests}");
        }
    }
}
