// How to create a list:
List<string> names = new List<string>();

// How to add to the list:
names.Add("Kyle");
names.Add("Tommy");
names.Add("Susan");

// Lists work with different types:
List<int> values = new List<int>();
values.Add(1);
values.Add(2);
values.Add(3);

// Build a list using Split & ToList
string data = "Alfred,Batman,Cromwell";
List<string> dc = data.Split(',').ToList();

// Print list to Console:
int i = 0;
Console.WriteLine("List of names from the names list:");
do
{
    Console.WriteLine("{0}: {1}", values[i], names[i]);
    i++;
} while (i < names.Count);

i = 0;
Console.WriteLine("\nList of names from the dc list:");
do
{
    Console.WriteLine("{0}: {1}", values[i], dc[i]);
    i++;
}  while (i < dc.Count);