// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-7.0

// How to create a Dictionary object in C#
// Keys must be unique
// Types do not have to be different you can have <string, string>, <int, int> etc
Dictionary<int, string> dayOfWeek = new Dictionary<int, string>();
dayOfWeek[1] = "Sunday";
dayOfWeek[2] = "Monday";
dayOfWeek[3] = "Tuesday";
dayOfWeek[4] = "Wednesday";
dayOfWeek[5] = "Thursday";
dayOfWeek[6] = "Friday";
dayOfWeek[7] = "Saturday";

int i = 0;
do
{
    Console.WriteLine("Day {0} of the week is {1}.", i + 1, dayOfWeek[i + 1]);
    i++;
} while (i < dayOfWeek.Count);