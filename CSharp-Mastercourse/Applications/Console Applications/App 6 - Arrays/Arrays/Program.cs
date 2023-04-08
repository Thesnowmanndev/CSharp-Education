int i = 0;

// Traditional String Array
string[] names = new string[5];
names[0] = "Esperanza Miles";
names[1] = "Sanai Huffman";
names[2] = "Dania Mcculough";
names[3] = "Kenneth Hayden";
names[4] = "Nikolas Goodwin";

Console.WriteLine("Names in a defined string array: ");
do
{
    Console.WriteLine(names[i]);
    i++;
} while (i < names.Length - 1);
Console.WriteLine("\n");

// How to seperate a string based off a char
string data = "Rey,Rodrigo,Nicholas,Amari,Kelly,Bella";
string[] seperatedFirstNames = data.Split(',');

i = 0;
Console.WriteLine("Names in Seperated First Names Array:");
do
{
    Console.WriteLine(seperatedFirstNames[i]);
    i++;
} while (i < seperatedFirstNames.Length - 1);
Console.WriteLine("\n");

// How to create a string array
string[] lastNames = new string[]
{
    "Patton",
    "Cobb",
    "Hansen",
    "Gibbs",
    "Huber",
    "Reese"
};

i = 0;
Console.WriteLine("Names in a string Array: ");
do
{
    Console.WriteLine(lastNames[i]);
    i++;
} while (i < lastNames.Length - 1);
Console.WriteLine("\n");

// Combine String Arrays
i = 0;
Console.WriteLine("Two string arrays combined to form full names:");
do
{
    Console.WriteLine(seperatedFirstNames[i] + " " + lastNames[i]);
    i++;
} while (i < lastNames.Length - 1);
Console.WriteLine("\n");

// Arrays for other types:
int[] ages = new int[] { 1, 2, 3, 4 };
double[] numbers = new double[] { 2.14, 3.24, 3.34, 4.44, 5.54 }; 